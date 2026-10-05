using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Rules;
using SharpVk.Generator.Specification.Elements;
using SharpVk.Generator.Specification.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace SharpVk.Generator.Specification
{
    public class TypeVideoElementReader
        : IWorker
    {
        private readonly IVkXmlCache xmlCache;
        private readonly NameParser nameParser;
        private readonly IEnumerable<ITypeExtensionRule> typeExtensions;

        private string[] primitives =
        {
            "uint32_t",
            "uint16_t",
            "uint8_t",
            "int32_t",
            "int16_t",
            "int8_t"
        };

        public TypeVideoElementReader(IVkXmlCache xmlCache, NameParser nameParser, IEnumerable<ITypeExtensionRule> typeExtensions)
        {
            this.xmlCache = xmlCache;
            this.nameParser = nameParser;
            this.typeExtensions = typeExtensions;
        }

        public void Execute(IServiceCollection target)
        {
            foreach (var videoType in this.xmlCache.GetVideoXml().Element("registry").Element("types").Elements("type"))
            {
                string name = videoType.Attribute("name")?.Value ?? videoType.Element("name")?.Value ?? videoType.Element("proto")?.Element("name")?.Value;
                Enum.TryParse(videoType.Attribute("category")?.Value, out TypeCategory category);
                string requires = videoType.Attribute("requires")?.Value;
                if (requires == null)
                    requires = videoType.Attribute("bitvalues")?.Value;
                string alias = videoType.Attribute("alias")?.Value;
                bool isTypePointer = false;

                //Disregard primitives as they are already present at vk.xml.
                if (primitives.Contains(name))
                    continue;
                if (category == TypeCategory.include)
                    continue;

                if (category == TypeCategory.define && !(videoType.DescendantNodes().First().ToString().Contains("#define")))
                {
                    category = TypeCategory.basetype;
                }

                
                if (((XElement)videoType.Elements("member")?.FirstOrDefault())?.Nodes().OfType<XText>().FirstOrDefault()?.Value.Contains(" : ") == true)
                //It's a bitmask not a type.
                {
                    var newBitmaskType = new TypeElement
                    {
                        VkName = name,
                        Category = TypeCategory.@enum,
                        Requires = requires,
                        Parent = null,
                        IsReturnedOnly = false,
                        Type = "bitmask",
                        IsTypePointer = isTypePointer,
                        IsVideoSpec = true,
                        Extends = null,
                        Alias = alias
                    };

                    if (!this.typeExtensions.ApplyFirst(videoType, newBitmaskType, target))
                    {
                        newBitmaskType.NameParts = new[] { name };
                        newBitmaskType.ExtensionNamespace = null;
                    }

                    target.AddSingleton(newBitmaskType);
                    continue;
                }

                string type = videoType.Element("type")?.Value;

                var newType = new TypeElement
                {
                    VkName = name,
                    Category = category,
                    Requires = requires,
                    Parent = null,
                    IsReturnedOnly = false,
                    Type = type,
                    IsTypePointer = isTypePointer,
                    IsVideoSpec = true,
                    Extends = null,
                    Alias = alias
                };

                if (!this.typeExtensions.ApplyFirst(videoType, newType, target))
                {
                    newType.NameParts = new[] { name };
                    newType.ExtensionNamespace = null;
                }

                target.AddSingleton(newType);
            }
        }
    }
}
