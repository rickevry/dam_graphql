using Dam.Repository;
using Dam.Repository.Attributes;
using Dam.Schemas.Attributes;
using Dam.Schemas.Entities.Bundle;
using Dam.Schemas.GraphTypes.Bundle;
using GraphQL;
using GraphQL.Types;
using System.Linq;

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
            BuildBundleFields();
        }

        private void BuildBundleFields()
        {
            var entityName = typeof(BundleEntity).GetCustomAttributes(typeof(EntityNameAttribute), false).Select(qn => qn as EntityNameAttribute).FirstOrDefault();
            if (entityName != null)
            {
                Field<BundleGraphType>(
                $"save{entityName}",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<BundleInputGraphType>> { Name = entityName.Name.ToLower() }
                ),
                resolve: context =>
                {
                    var bundle = context.GetArgument<BundleEntity>(entityName.Name.ToLower());
                    var saved = _entityRepositoryProvider.GetRepository<BundleEntity>().SaveAsync(bundle);

                    return saved;
                });
            }
        }
    }
}
