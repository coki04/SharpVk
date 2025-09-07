using SharpVk.Emit;
using SharpVk.Generator.Generation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Emission
{
    public class CacheStructEmitter
        : IOutputWorker
    {
        private readonly IEnumerable<DelegateDefinition> delegates;
        private readonly FileBuilderFactory builderFactory;

        public CacheStructEmitter(IEnumerable<DelegateDefinition> delegates, FileBuilderFactory builderFactory)
        {
            this.delegates = delegates.Where(x => x.VkName != null).ToArray();
            this.builderFactory = builderFactory;
        }

        public void Execute()
        {
            this.builderFactory.Generate("CommandCacheStruct", null, fileBuilder =>
            {
                fileBuilder.EmitUsing("System.Runtime.InteropServices");

                fileBuilder.EmitNamespace("SharpVk", namespaceBuilder =>
                {
                    namespaceBuilder.EmitType(TypeKind.Struct, "CommandCacheStruct", typeBuilder =>
                    {
                        foreach (var @delegate in this.delegates)
                        {
                            typeBuilder.EmitField(string.Join('.', @delegate.Namespace) + "." + @delegate.Name, @delegate.VkName, AccessModifier.Public, MemberModifier.Readonly);
                        }

                        typeBuilder.EmitConstructor(constructor =>
                        {
                            foreach (var @delegate in this.delegates)
                            {
                                if (@delegate.LookupScopes != null)
                                {
                                    foreach (var lookupScope in @delegate.LookupScopes)
                                    {
                                        constructor.EmitAssignment(Member(This, @delegate.VkName), Call(Variable("cache"), $"GetCommandDelegate<{string.Join('.', @delegate.Namespace) + '.' + @delegate.Name}>", Literal(@delegate.VkName), Literal(lookupScope)));
                                    }
                                }
                                else
                                {
                                    constructor.EmitAssignment(Member(This, @delegate.VkName), Call(Variable("cache"), $"GetCommandDelegate<{string.Join('.', @delegate.Namespace) + '.' + @delegate.Name}>", Literal(@delegate.VkName), Literal("")));
                                }
                            }
                        }, param => param.EmitParam("CommandCache", "cache"), AccessModifier.Public);
                    }, accessModifier: AccessModifier.Internal, modifiers: TypeModifier.Partial);
                });
            });
        }
    }
}
