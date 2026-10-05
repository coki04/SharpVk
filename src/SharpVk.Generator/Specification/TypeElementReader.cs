using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Rules;
using SharpVk.Generator.Specification.Elements;
using SharpVk.Generator.Specification.Rules;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Specification
{
    public class TypeElementReader
        : IWorker
    {
        private readonly IVkXmlCache xmlCache;
        private readonly NameParser nameParser;
        private readonly IEnumerable<ITypeExtensionRule> typeExtensions;

        public TypeElementReader(IVkXmlCache xmlCache, NameParser nameParser, IEnumerable<ITypeExtensionRule> typeExtensions)
        {
            this.xmlCache = xmlCache;
            this.nameParser = nameParser;
            this.typeExtensions = typeExtensions;
        }

        public void Execute(IServiceCollection target)
        {
            foreach (var vkType in this.xmlCache.GetVkXml().Element("registry").Element("types").Elements("type"))
            {
                string name = vkType.Attribute("name")?.Value ?? vkType.Element("name")?.Value ?? vkType.Element("proto")?.Element("name")?.Value;
                Enum.TryParse(vkType.Attribute("category")?.Value, out TypeCategory category);
                string requires = vkType.Attribute("requires")?.Value;
                if (requires == null)
                    requires = vkType.Attribute("bitvalues")?.Value;
                string parent = vkType.Attribute("parent")?.Value;
                var extends = vkType.Attribute("structextends")?.Value?.Split(',')?.Select(x => x.Trim())?.ToList();
                string alias = vkType.Attribute("alias")?.Value;
                bool.TryParse(vkType.Attribute("returnedonly")?.Value, out bool isReturnedOnly);
                bool isTypePointer = false;

                //Disregard video types from vk.xml as they are imported from video.xml instead
                if (requires != null && requires.StartsWith("vk_video/"))
                    continue;

                //FIXME: Keep an eye on the spec to commit https://github.com/KhronosGroup/Vulkan-Docs/pull/2826
                //Wrong spec for VkQueueFamilyDataGraphPropertiesARM. It is also used as an input.
                if (isReturnedOnly && name == "VkQueueFamilyDataGraphPropertiesARM")
                    isReturnedOnly = false;
                //Wrong spec for VkGpaDeviceGetClockInfoAMD. It is only used as an output.
                if (!isReturnedOnly && name == "VkGpaDeviceGetClockInfoAMD")
                    isReturnedOnly = true;

                if (category == TypeCategory.define && !(vkType.DescendantNodes().First().ToString().Contains("#define")))
                {
                    category = TypeCategory.basetype;
                }

                string type = vkType.Element("type")?.Value;

                string[] apis = vkType.Attribute("api")?.Value?.Split(',');
                if (apis != null && !apis.Contains("vulkan"))
                    continue;

                if (type == "VK_MAKE_VERSION")
                {
                    type += vkType.Element("type").NextNode.ToString();
                }

                if (parent != null)
                {
                    parent = parent.Split(',').First();

                    if (name == "VkSwapchainKHR")
                    {
                        parent = "VkDevice";
                    }
                }

                var newType = new TypeElement
                {
                    VkName = name,
                    Category = category,
                    Requires = requires,
                    Parent = parent,
                    IsReturnedOnly = isReturnedOnly,
                    Type = type,
                    IsTypePointer = isTypePointer,
                    IsVideoSpec = false,
                    Extends = extends,
                    Alias = alias
                };

                if (!this.typeExtensions.ApplyFirst(vkType, newType, target))
                {
                    newType.NameParts = new[] { name };
                    newType.ExtensionNamespace = null;
                }

                target.AddSingleton(newType);
            }
        }
    }
}
