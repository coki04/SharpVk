using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Specification.Elements;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace SharpVk.Generator.Specification.Rules
{
    public class FunctionPointerTypeRule
        : ITypeExtensionRule
    {
        private readonly NameParser nameParser;

        public FunctionPointerTypeRule(NameParser nameParser)
        {
            this.nameParser = nameParser;
        }

        public bool Apply(XElement typeXml, TypeElement type, IServiceCollection target)
        {
            if (type.Category != TypeCategory.funcpointer)
            {
                return false;
            }

            bool isProto = ! (typeXml.Nodes().First() is XText);
            string returnType = typeXml.Nodes().First() switch
            {
                //Regular case. The type is directly specified.
                XText text => text.Value.Split(' ')[1],
                //Proto case. The type name is specified inside <proto> node.
                XElement elem => ((XText)((XElement)elem.Nodes().First()).Nodes().First()).Value,
                _ => null,
            };

            if (returnType.EndsWith("*"))
            {
                returnType = returnType.TrimEnd('*');

                type.IsTypePointer = true;
            }

            type.Type = returnType;
            
            type.NameParts = this.nameParser.ParseFunctionPointer(type.VkName, out type.ExtensionNamespace);

            if (!isProto)
            {
                var functionTail = typeXml.Element("name").NodesAfterSelf();

                foreach (var typeElement in functionTail.Where(x => x.NodeType == XmlNodeType.Element).Cast<XElement>())
                {
                    string pre = ((XText)typeElement.PreviousNode).Value.Split(',').Last().Trim('(', ')', ';').TrimStart();
                    string post = ((XText)typeElement.NextNode).Value.Split(',').First().Trim('(', ')', ';').TrimEnd();

                    string paramName = new string(post.Reverse().TakeWhile(char.IsLetterOrDigit).Reverse().ToArray());
                    string typeString = pre + "@" + (post.Substring(0, post.Length - paramName.Length).Trim());
                    string paramType = typeElement.Value;
                    PointerType pointerType = PointerTypeUtil.Map(typeString);
                    
                    var paramNameParts = this.nameParser.GetNameParts(paramName, out string paramExtension);

                    type.Members.Add(new MemberElement
                    {
                        VkName = paramName,
                        Type = paramType,
                        PointerType = pointerType,
                        NameParts = paramNameParts
                    });
                }
            }
            else
            {
                foreach (var typeElement in typeXml.Nodes().Where(x => x.NodeType == XmlNodeType.Element && ((XElement)x).Name == "param").Cast<XElement>())
                {
                    string paramName = ((XElement)typeElement.Nodes().Single(x => x.NodeType == XmlNodeType.Element && ((XElement)x).Name == "name")).Value;
                    string typeString = ((XElement)typeElement.Nodes().Single(x => x.NodeType == XmlNodeType.Element && ((XElement)x).Name == "type")).Value;
                    string pointerTypeString = string.Join(" ", typeElement.Value.Split(' ').Where(s => !string.IsNullOrWhiteSpace(s))).Replace(typeString, "@");
                    pointerTypeString = pointerTypeString.Substring(0, pointerTypeString.Length - paramName.Length).TrimEnd();
                    string paramType = typeElement.Value;
                    PointerType pointerType = PointerTypeUtil.Map(pointerTypeString);
                    
                    var paramNameParts = this.nameParser.GetNameParts(paramName, out string paramExtension);

                    type.Members.Add(new MemberElement
                    {
                        VkName = paramName,
                        Type = typeString,
                        PointerType = pointerType,
                        NameParts = paramNameParts
                    });
                }
            }

            return true;
        }
    }
}
