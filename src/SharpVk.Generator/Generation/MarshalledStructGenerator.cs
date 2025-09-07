using Microsoft.Extensions.DependencyInjection;
using SharpVk.Emit;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Generation.Marshalling;
using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation
{
    public class MarshalledStructGenerator
        : IWorker
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;
        private readonly IEnumerable<IMemberPatternRule> patternRules;
        private readonly NamespaceMap namespaceMap;
        private readonly CommentGenerator commentGenerator;
        private readonly IEnumerable<IMemberPatternRule> memberPatternRules;
        private readonly ParsedExpressionTokenCheck tokenCheck;

        public MarshalledStructGenerator(Dictionary<string, TypeDeclaration> typeData, NameLookup nameLookup, IEnumerable<IMemberPatternRule> patternRules, 
                                         NamespaceMap namespaceMap, CommentGenerator commentGenerator, IEnumerable<IMemberPatternRule> memberPatternRules,
                                         ParsedExpressionTokenCheck tokenCheck)
        {
            this.typeData = typeData;
            this.nameLookup = nameLookup;
            this.patternRules = patternRules;
            this.namespaceMap = namespaceMap;
            this.commentGenerator = commentGenerator;
            this.memberPatternRules = memberPatternRules;
            this.tokenCheck = tokenCheck;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var typeItem in this.typeData.Where(x => x.Value.Pattern == TypePattern.MarshalledStruct))
            {
                var type = typeItem.Value;
                var typeNamespace = new List<string>();

                if (type.Extension != null)
                {
                    typeNamespace.AddRange(this.namespaceMap.Map(type.Extension));
                }

                var publicStruct = new StructDefinition
                {
                    Name = type.Name,
                    Namespace = typeNamespace.ToArray(),
                    Comment = this.commentGenerator.Lookup(typeItem.Key),
                    Methods = new List<MethodDefinition>(),
                    Properties = new List<MemberDefinition>()
                };

                var marshalToMethod = new MethodDefinition
                {
                    Name = "MarshalTo",
                    IsUnsafe = true,
                    ParamActions = new List<ParamActionDefinition>
                    {
                        new ParamActionDefinition
                        {
                            Param = new ParamDefinition
                            {
                                Name = "pointer",
                                Type = this.nameLookup.Lookup(new TypeReference
                                {
                                    VkName = typeItem.Key,
                                    PointerType = PointerType.Pointer
                                }, true)
                            }
                        }
                    },
                    MemberActions = new List<MethodAction>()
                };


                var marshalFromMethod = new MethodDefinition
                {
                    Name = "MarshalFrom",
                    ReturnType = type.Name,
                    IsUnsafe = true,
                    IsStatic = true,
                    ParamActions = new List<ParamActionDefinition>
                    {
                        new ParamActionDefinition
                        {
                            Param = new ParamDefinition
                            {
                                Name = "pointer",
                                Type = this.nameLookup.Lookup(new TypeReference
                                {
                                    VkName = typeItem.Key,
                                    PointerType = PointerType.Pointer
                                }, true)
                            }
                        }
                    },
                    MemberActions = new List<MethodAction>()
                };

                if (!type.IsOutputOnly || (type.Extends?.Any(x => !this.typeData[x].IsOutputOnly) ?? false) || 
                        type.Name.EndsWith("ExtensionProperties") ||
                        type.Name.EndsWith("RenderPassSubpassFeedbackInfo") ||
                        type.Name.EndsWith("FaultData") ||
                        type.Name.EndsWith("VideoEncodeSessionParametersFeedbackInfo") ||
                        type.Name.EndsWith("PhysicalDeviceLayeredApiProperties") ||
                        type.Name.EndsWith("LatencyTimingsFrameReport"))
                {
                    publicStruct.Methods.Add(marshalToMethod);
                }

                if (type.IsOutputOnly || ((!type.Name.EndsWith("Info") ||
                                            type.Name.EndsWith("AccelerationStructureBuildSizesInfo") ||
                                            type.Name.EndsWith("DescriptorSetLayoutHostMappingInfo") ||
                                            type.Name.EndsWith("MicromapBuildSizesInfo") ||
                                            type.Name.EndsWith("DeviceFaultVendorInfo")) && type.Members.All(this.CanMarshalFrom))

                                            || type.Name.EndsWith("DeviceFaultInfo") ||
                                               type.Name.EndsWith("GetLatencyMarkerInfo"))
                {
                    publicStruct.Methods.Add(marshalFromMethod);
                }

                typeNamespace.Insert(0, "Interop");

                var interopStruct = new StructDefinition
                {
                    Name = type.Name,
                    Namespace = typeNamespace.ToArray(),
                    IsUnsafe = true,
                    Fields = new List<MemberDefinition>()
                };

                if (type.ExtendTypes.Count > 0 && 
                    (type.Name.Contains("InstanceCreateInfo") ||
                     type.Name.Contains("DeviceCreateInfo")))
                {
                    interopStruct.Constructor = new MethodDefinition
                    {
                        ParamActions = new List<ParamActionDefinition>(),
                        MemberActions = new List<MethodAction>(),
                    };

                    var paramDeclarations = new List<ParamDeclaration>();
                    string typeVkName = typeItem.Key;
                    paramDeclarations.Add(new ParamDeclaration()
                    {
                        Name = type.Name,
                        IsOptional = true,
                        Dimensions = null,
                        NoAutoValidity = true,
                        VkName = typeVkName,
                        Type = new TypeReference { VkName = typeVkName },
                    });

                    var marshalToActions = new List<MethodAction>();

                    foreach (var parameter in paramDeclarations)
                    {
                        var newParams = this.GenerateParameter(paramDeclarations, parameter, marshalToActions, null);

                        if (newParams != null)
                        {
                            interopStruct.Constructor.ParamActions.AddRange(newParams);
                        }
                    }

                    interopStruct.Constructor.MemberActions.AddRange(marshalToActions);
                }

                foreach (var member in type.Members)
                {
                    var patternInfo = new MemberPatternInfo
                    {
                    };

                    this.patternRules.ApplyFirst(type.Members, member, new MemberPatternContext(null, false, false, 0, type.Extension, x => Default(this.nameLookup.Lookup(new TypeReference { VkName = x }, false)), typeItem.Key), patternInfo);

                    marshalToMethod.MemberActions.AddRange(patternInfo.MarshalTo.Select(action => action(targetName => DerefMember(Variable("pointer"), targetName), valueName => Member(This, valueName))));
                    marshalFromMethod.MemberActions.AddRange(patternInfo.MarshalFrom.Select(action => action(targetName => Member(Variable("result"), targetName), valueName => DerefMember(Variable("pointer"), valueName))));

                    foreach (var publicMember in patternInfo.Public)
                    {
                        publicStruct.Properties.Add(new MemberDefinition
                        {
                            Name = publicMember.Name,
                            Type = publicMember.Type,
                            Comment = this.commentGenerator.Lookup(typeItem.Key, member.VkName)
                        });
                    }

                    if (patternInfo.Interop.Repeats.HasValue)
                    {
                        for (int index = 0; index < patternInfo.Interop.Repeats.Value; index++)
                        {
                            interopStruct.Fields.Add(new MemberDefinition
                            {
                                Name = patternInfo.Interop.Name + "_" + index,
                                Type = patternInfo.Interop.Type
                            });
                        }
                    }
                    else
                    {
                        interopStruct.Fields.Add(new MemberDefinition
                        {
                            Name = patternInfo.Interop.Name,
                            Type = patternInfo.Interop.Type,
                            Comment = this.commentGenerator.Lookup(typeItem.Key, member.VkName)
                        });
                    }

                }

                services.AddSingleton(publicStruct);

                services.AddSingleton(interopStruct);
            }
        }

        private bool CanMarshalFrom(MemberDeclaration param)
        {
            var typeData = this.typeData[param.Type.VkName];

            return typeData.Pattern != TypePattern.Delegate
                    && !typeData.Name.EndsWith("Info");
        }

        private IEnumerable<ParamActionDefinition> GenerateParameter(List<ParamDeclaration> parameters, ParamDeclaration parameter, List<MethodAction> marshalToActions, string extension)
        {
            var result = new List<ParamActionDefinition>();
           
            var patternInfo = new MemberPatternInfo();

            this.memberPatternRules.ApplyFirst(parameters, parameter, new MemberPatternContext("", true, false, 0, extension, null, "CreateInfo"), patternInfo);

            var actionList = marshalToActions;

            Func<string, Action<ExpressionBuilder>> getValue = valueName => Variable(valueName);

            foreach (var publicMember in patternInfo.Public)
            {
                result.Add(new ParamActionDefinition
                {
                    Param = new ParamDefinition
                    {
                        Name = publicMember.Name,
                        Comment = publicMember.Comment,
                        Type = publicMember.Type,
                        DefaultValue = publicMember.DefaultValue
                    }
                });
            }

            if (patternInfo.MarshalTo.Any())
            {
                string marshalledName = "this";

                var newMarshalToActions = patternInfo.MarshalTo.Select(action => action(targetName => Variable(marshalledName), getValue));

                actionList.AddRange(newMarshalToActions);
            }
            

            return result;
        }
    }
}
