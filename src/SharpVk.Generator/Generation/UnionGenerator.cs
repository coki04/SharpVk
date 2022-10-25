using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Generation
{
    public class UnionGenerator
        : IWorker
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly IEnumerable<EnumDeclaration> enumData;
        private readonly NameLookup nameLookup;
        private readonly NamespaceMap namespaceMap;
        private readonly CommentGenerator commentGenerator;

        public UnionGenerator(Dictionary<string, TypeDeclaration> typeData, IEnumerable<EnumDeclaration> enumData, NameLookup nameLookup, NamespaceMap namespaceMap, CommentGenerator commentGenerator)
        {
            this.typeData = typeData;
            this.enumData = enumData;
            this.nameLookup = nameLookup;
            this.namespaceMap = namespaceMap;
            this.commentGenerator = commentGenerator;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var typeItem in this.typeData.Where(x => x.Value.Pattern == TypePattern.Union && x.Value.Members.All(x => x.SelectedBy != null)))
            {
                var type = typeItem.Value;

                services.AddSingleton(new StructDefinition
                {
                    Name = type.Name,
                    Namespace = type.Extension != null ? this.namespaceMap.Map(type.Extension).ToArray() : null,
                    Comment = this.commentGenerator.Lookup(typeItem.Key),
                    HasZero = type.Members.All(IsNumeric),
                    IsUnion = true,
                    IsUnsafe = true,
                    Constructor = new MethodDefinition
                    {
                        ParamActions = type.Members.Select(this.GetConstructorParam).ToList()
                    },
                    Fields = type.Members.Select(x => new MemberDefinition
                    {
                        Name = x.Name,
                        Type = this.nameLookup.Lookup(x.Type, false),
                        Comment = this.commentGenerator.Lookup(typeItem.Key, x.VkName),
                    }).ToList()
                });
            }
        }

        private static readonly string[] NumericsTypes = new[] { "uint32_t", "uint64_t", "int32_t", "int64_t", "float" };

        private static bool IsNumeric(MemberDeclaration member)
        {
            return !member.RequiresMarshalling
                        & NumericsTypes.Contains(member.Type.VkName);
        }

        private ParamActionDefinition GetConstructorParam(MemberDeclaration member)
        {
            return new ParamActionDefinition
            {
                MemberName = member.Name,
                Param = new ParamDefinition
                {
                    Name = member.ParamName,
                    Type = this.nameLookup.Lookup(member.Type, true)
                }
            };
        }
    }
}
