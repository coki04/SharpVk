using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Specification.Elements;
using System.Linq;
using System.Xml.Linq;

namespace SharpVk.Generator.Specification.Rules
{
    public class MemberTypeVideoRule
        : ITypeExtensionRule
    {
        private readonly NameParser nameParser;

        public MemberTypeVideoRule(NameParser nameParser)
        {
            this.nameParser = nameParser;
        }

        public bool Apply(XElement typeXml, TypeElement type, IServiceCollection target)
        {
            if (!type.IsVideoSpec || type.Category == TypeCategory.include || type.Category == TypeCategory.None || type.Category == TypeCategory.define)
            {
                return false;
            }

            type.NameParts = this.nameParser.GetNameParts(type.VkName, out type.ExtensionNamespace);

            foreach (var vkMember in typeXml.Elements("member"))
            {
                var nameElement = vkMember.Element("name");
                string vkName = nameElement.Value;
                string memberType = vkMember.Element("type").Value;
                string selectedBy = vkMember.Attribute("selection")?.Value;
                bool.TryParse(vkMember.Attribute("optional")?.Value, out bool isOptional);
                bool.TryParse(vkMember.Attribute("noautovalidity")?.Value, out bool noAutoValidity);

                PointerType pointerType = PointerTypeUtil.GetFrom(nameElement.NodesBeforeSelf());

                var fixedLength = new FixedLengthDeclaration();

                if (nameElement.NodesAfterSelf().Any())
                {
                    string enumName = vkMember.Element("enum")?.Value;

                    if (enumName != null)
                    {
                        fixedLength.Value = enumName;
                        fixedLength.Type = FixedLengthType.EnumReference;
                    }
                    else if(nameElement.NextNode.NodeType == System.Xml.XmlNodeType.Text)
                    {
                        //FIXME: Check spec to commit https://github.com/KhronosGroup/Vulkan-Docs/pull/2827
                        //Spec wrong. It should be in <enum> but it's not.
                        if (nameElement.NextNode.ToString() == "[STD_VIDEO_H264_MAX_NUM_LIST_REF]")
                        {
                            fixedLength.Value = "STD_VIDEO_H264_MAX_NUM_LIST_REF";
                            fixedLength.Type = FixedLengthType.EnumReference;
                        }
                        else if (nameElement.NextNode.ToString() == "[STD_VIDEO_H265_MAX_NUM_LIST_REF]")
                        {
                            fixedLength.Value = "STD_VIDEO_H265_MAX_NUM_LIST_REF";
                            fixedLength.Type = FixedLengthType.EnumReference;
                        }
                        else if (nameElement.NextNode.ToString().TrimStart().StartsWith(": "))
                        {
                            fixedLength.Value = null;
                            fixedLength.Type = FixedLengthType.None;
                        }
                        else if (nameElement.NextNode.ToString().Length > 0 && nameElement.NextNode.ToString()[0] == ':')
                        {
                            fixedLength.Value = SimpleVideoParser.ParseBitfieldLength(nameElement.NextNode.ToString());
                            fixedLength.Type = FixedLengthType.IntegerLiteral;
                        }
                        else
                        {
                            fixedLength.Value = SimpleVideoParser.ParseFixedLength(nameElement.NextNode.ToString());
                            fixedLength.Type = FixedLengthType.IntegerLiteral;
                        }
                    }
                }
                else
                {
                    int fixedLengthIndex = vkName.IndexOf('[');

                    if (fixedLengthIndex >= 0)
                    {
                        string fixedLengthString = vkName.Substring(fixedLengthIndex);
                        vkName = vkName.Substring(0, fixedLengthIndex);

                        fixedLength.Value = SimpleVideoParser.ParseFixedLength(fixedLengthString);
                        fixedLength.Type = FixedLengthType.IntegerLiteral;
                    }
                }

                var lenField = vkMember.Attribute("len");
                MemberLen[] dimensions;
                if (lenField != null && lenField.Value == "*_max_sub_layers_minus1 + 1")
                //Very special case where the length comes from a container struct. 
                //Fixing it to STD_VIDEO_H265_SUBLAYERS_LIST_SIZE as it is the maximum size it can get to.
                {
                    dimensions = new MemberLen[] { new MemberLen() { 
                        Type = LenType.Expression, Value = new LenExpressionToken() { Value = "STD_VIDEO_H265_SUBLAYERS_LIST_SIZE" } 
                        } };
                }
                else
                {
                    dimensions = lenField != null
                                        ? SimpleVideoParser.ParsedLenField(lenField.Value)
                                        : null;
                }

                string[] memberNameParts = this.nameParser.ParseParamName(vkName, pointerType, out string memberExtension);

                string values = vkMember.Attribute("values")?.Value;

                var newMember = new MemberElement
                {
                    VkName = vkName,
                    Type = memberType,
                    IsOptional = isOptional,
                    NoAutoValidity = noAutoValidity,
                    FixedLength = fixedLength,
                    PointerType = pointerType,
                    NameParts = memberNameParts,
                    ExtensionNamespace = memberExtension,
                    Dimensions = dimensions,
                    Values = values,
                    SelectedBy = selectedBy,
                };

                type.Members.Add(newMember);
            }

            return true;
        }
    }
}
