using Dam.Repository;
using Dam.Schemas.Entities.Bundle;
using Dam.Schemas.GraphTypes.Bundle;
using GraphQL;
using GraphQL.Types;

namespace Dam.Schemas
{
    public class DamMutation : ObjectGraphType
    {
        private readonly IEntityRepositoryProvider _entityRepositoryProvider;

        public DamMutation(IEntityRepositoryProvider entityRepositoryProvider)
        {
            _entityRepositoryProvider = entityRepositoryProvider;

            BuildMutableFields();
        }

        private void BuildMutableFields()
        {
            BuildBundleField();
        }

        private void BuildBundleField()
        {
            Field<BundleGraphType>(
                "createBundle",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<BundleInputGraphType>> { Name = "bundle" }
                ),
                resolve: context =>
                {
                    var bundle = context.GetArgument<BundleEntity>("bundle");
                    var saved = _entityRepositoryProvider.GetRepository<BundleEntity>().Save(bundle);

                    return saved;
                });
        }
    }
}
