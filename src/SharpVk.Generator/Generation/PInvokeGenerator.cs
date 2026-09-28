using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Generation
{
    public class PInvokeGenerator
        : IWorker
    {
        private readonly Dictionary<string, ExtensionDeclaration> extensions;
        private readonly IEnumerable<CommandDeclaration> commands;
        private readonly NamespaceMap namespaceMap;
        private readonly NameLookup nameLookup;

        public PInvokeGenerator(IEnumerable<CommandDeclaration> commands, IEnumerable<ExtensionDeclaration> extensions, NamespaceMap namespaceMap, NameLookup nameLookup)
        {
            this.extensions = extensions.ToDictionary(x => x.Name);
            this.commands = commands;
            this.namespaceMap = namespaceMap;
            this.nameLookup = nameLookup;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var command in this.commands)
            {
                if (command.ExtensionNamespace == null)
                {
                    services.AddSingleton(new PInvokeDefinition
                    {
                        Name = command.VkName,
                        ReturnType = this.nameLookup.Lookup(new TypeReference { VkName = command.ReturnType }, true),
                        Parameters = command.Params.Select(x => new ParamDefinition
                        {
                            Name = x.Name,
                            Type = this.nameLookup.Lookup(x.Type, true)
                        }).ToList()
                    });
                }

                List<string> lookupScopes = new List<string>();
                if (command.Extensions != null)
                {
                    bool lookupInstance = command.Params.Count(x => x.Type.VkName == "VkInstance") > 0 ||
                                          command.Params.Count(x => x.Type.VkName == "VkPhysicalDevice") > 0;
                    if (lookupInstance)
                        lookupScopes.Add("instance");
                    else
                        lookupScopes.Add("device");
                }
                else
                {
                    lookupScopes.Add("");
                }

                services.AddSingleton(new DelegateDefinition
                {
                    Name = $"{command.HandleTypeName}{command.Name}Delegate",
                    Namespace = this.namespaceMap.Map(command.ExtensionNamespace).Prepend("Interop").ToArray(),
                    ReturnType = this.nameLookup.Lookup(new TypeReference { VkName = command.ReturnType }, true),
                    IsUnsafe = true,
                    Parameters = command.Params.Select(x => new ParamDefinition
                    {
                        Name = x.Name,
                        Type = this.nameLookup.Lookup(x.Type, true)
                    }).ToList(),
                    VkName = command.VkName,
                    LookupScopes = lookupScopes,
                });
            }
        }
    }
}
