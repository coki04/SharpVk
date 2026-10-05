using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Specification.Elements;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System;
using System.Globalization;

namespace SharpVk.Generator.Specification
{
    public class EnumVideoElementReader
        : IWorker
    {
        private readonly IVkXmlCache xmlCache;
        private readonly NameParser nameParser;

        public EnumVideoElementReader(IVkXmlCache xmlCache, NameParser nameParser)
        {
            this.xmlCache = xmlCache;
            this.nameParser = nameParser;
        }

        public void Execute(IServiceCollection target)
        {
            var enums = new Dictionary<string, EnumElement>();

            var constantsEnum = new EnumElement
            {
                VkName = "Video Constants",
                Type = "enum",
                Bitwidth = 32,
                NameParts = new string[] { "Video Constants" },
                ExtensionNamespace = null
            };
            enums.Add("Video Constants", constantsEnum);

            foreach (var videoEnum in this.xmlCache.GetVideoXml().Element("registry").Elements("enums"))
            {
                string name = videoEnum.Attribute("name").Value;
                string type = videoEnum.Attribute("type")?.Value;
                int bitwidth = 32;
                if (videoEnum.Attribute("bitwidth") != null)
                    bitwidth = int.Parse(videoEnum.Attribute("bitwidth")?.Value);

                string extension = null;
                string[] nameParts = this.nameParser.GetNameParts(name, out extension);

                var newEnum = new EnumElement
                {
                    VkName = name,
                    Type = type,
                    Bitwidth = bitwidth,
                    NameParts = nameParts,
                    ExtensionNamespace = extension
                };

                foreach (var vkField in videoEnum.Elements("enum"))
                {
                    string fieldName = vkField.Attribute("name").Value;
                    bool isBitmask = true;
                    string value = vkField.Attribute("bitpos")?.Value;
                    string comment = SimpleParser.NormaliseComment(vkField.Attribute("comment")?.Value);

                    if (value == null)
                    {
                        isBitmask = false;
                        value = vkField.Attribute("value")?.Value;

                        // Special case for mapping C "unsigned long long"
                        // (64-bit unsigned integer) to C# UInt64
                        if (value == "(~0ULL)")
                        {
                            value = "(~0UL)";
                        }

                        value = value?.Trim('(', ')');
                    }

                    IEnumerable<string> fieldNameParts = this.nameParser.ParseEnumField(fieldName, nameParts);

                    newEnum.Fields.Add(fieldName, new EnumField
                    {
                        VkName = fieldName,
                        NameParts = fieldNameParts.ToArray(),
                        IsBitmask = isBitmask,
                        Value = value,
                        Comment = comment != null ? new List<string> { comment } : null
                    });
                }

                enums.Add(name, newEnum);
            }

            foreach (var videoType in this.xmlCache.GetVideoXml().Element("registry").Element("types").Elements("type"))
            {
                string name = videoType.Attribute("name")?.Value ?? videoType.Element("name")?.Value ?? videoType.Element("proto")?.Element("name")?.Value;
                Enum.TryParse(videoType.Attribute("category")?.Value, out TypeCategory category);
                string requires = videoType.Attribute("requires")?.Value;
                if (requires == null)
                    requires = videoType.Attribute("bitvalues")?.Value;
                string alias = videoType.Attribute("alias")?.Value;
                string extension = null;
                
                //Detecting bitmasks encoded as types instead of enums..
                if (((XElement)videoType.Elements("member")?.FirstOrDefault())?.Nodes().OfType<XText>().FirstOrDefault()?.Value.Contains(" : ") != true)
                    //We're only looking for bitmasks here.
                    continue;

                int bitwidth = 32;
                if (videoType.Attribute("bitwidth") != null)
                    bitwidth = int.Parse(videoType.Attribute("bitwidth")?.Value);

                string type = "bitmask";

                string[] nameParts = this.nameParser.GetNameParts(name, out extension);

                var newEnum = new EnumElement
                {
                    VkName = name,
                    Type = type,
                    Bitwidth = bitwidth,
                    NameParts = nameParts,
                    ExtensionNamespace = extension
                };

                int bitmaskPos = 0;
                foreach (var vkField in videoType.Elements("member"))
                {
                    string fieldName = vkField.Element("name")?.Value;
                    bool isBitmask = true;
                    string text = vkField.Nodes().OfType<XText>().FirstOrDefault()?.Value;
                    string value = text.TrimStart().StartsWith(": ") ? text.TrimStart().Substring(2) : null;
                    string comment = SimpleParser.NormaliseComment(vkField.Attribute("comment")?.Value);

                    IEnumerable<string> fieldNameParts = this.nameParser.ParseEnumField(fieldName, nameParts);
                    if (fieldName.StartsWith("reserved")) //Apparently there is a extension called "reserved", so these fields get no nameparts..
                        fieldNameParts = new string[] { fieldName };

                    newEnum.Fields.Add(fieldName, new EnumField
                    {
                        VkName = fieldName,
                        NameParts = fieldNameParts.ToArray(),
                        IsBitmask = isBitmask,
                        Value = bitmaskPos.ToString(),
                        Comment = comment != null ? new List<string> { comment } : null
                    });

                    bitmaskPos += int.Parse(value);
                }

                enums.Add(name, newEnum);
            }

            var requireSets = this.xmlCache.GetVideoXml()
                                            .Element("registry")
                                            .Elements("feature")
                                            .Concat(this.xmlCache.GetVideoXml()
                                                                    .Element("registry")
                                                                    .Element("extensions")
                                                                    .Elements("extension"));
            foreach (var vkExtension in requireSets)
            {
                string extensionSuffix = null;

                if (vkExtension.Attribute("name") != null)
                {
                    string extensionName = vkExtension.Attribute("name").Value;

                    var extensionNameParts = extensionName.Split('_');

                    extensionSuffix = extensionNameParts[1].ToLower().FirstToUpper();
                }

                foreach (var vkExtensionEnum in vkExtension.Elements("require")
                                                            .SelectMany(x => x.Elements("enum")))
                {
                    string vkName = vkExtensionEnum.Attribute("name").Value;
                    var extendedEnum = enums["Video Constants"];

                    int? value = null;
                    bool isBitmask = false;

                    if (vkExtensionEnum.Attribute("offset") != null)
                    {
                        int offset = int.Parse(vkExtensionEnum.Attribute("offset").Value);

                        int extensionNumber = vkExtensionEnum.Attribute("extnumber") != null
                                                ? int.Parse(vkExtensionEnum.Attribute("extnumber").Value)
                                                : int.Parse(vkExtension.Attribute("number").Value);

                        value = 1000000000 + 1000 * (extensionNumber - 1) + offset;
                    }
                    else if (vkExtensionEnum.Attribute("bitpos") != null)
                    {
                        value = int.Parse(vkExtensionEnum.Attribute("bitpos").Value);
                        isBitmask = true;
                    }
                    else if (vkExtensionEnum.Attribute("value") != null && !vkExtensionEnum.Attribute("value").Value.Contains("_"))
                    {
                        value = vkExtensionEnum.Attribute("value").Value.StartsWith("0x", StringComparison.OrdinalIgnoreCase)
                                                ? int.Parse(vkExtensionEnum.Attribute("value").Value[2..], NumberStyles.HexNumber)
                                                : int.Parse(vkExtensionEnum.Attribute("value").Value);
                    }

                    if (vkExtensionEnum.Attribute("dir")?.Value == "-")
                    {
                        value = -value;
                    }

                    var nameParts = this.nameParser.ParseEnumField(vkName, extendedEnum.NameParts);

                    extendedEnum.Fields[vkName] = new EnumField
                    {
                        VkName = vkName,
                        Value = value?.ToString(),
                        NameParts = nameParts.ToArray(),
                        IsBitmask = isBitmask,
                        ExtensionNamespace = extensionSuffix
                    };
                }
            }

            foreach (var element in enums.Values)
            {
                target.AddSingleton(element);
            }
        }
    }
}
