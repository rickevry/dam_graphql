using Dam.Repository;
using Dam.Schemas.Attributes;
using Dam.Schemas.Entities.Bundle;
using Dam.Schemas.GraphTypes.Bundle;
using GraphQL;
using GraphQL.Types;
using System;
using System.Linq;

namespace Dam.Schemas
{
    public class DamQuery : ObjectGraphType
    {
        private readonly IEntityRepositoryProvider _entityRepositoryProvider;

        public DamQuery(IEntityRepositoryProvider entityRepositoryProvider)
        {
            _entityRepositoryProvider = entityRepositoryProvider;

            BuildQueryFields();
        }

        private void BuildQueryFields()
        {
            BuildBundleField();
        }

        private void BuildBundleField()
        {
            var queryName = typeof(BundleEntity).GetCustomAttributes(typeof(QueryNameAttribute), false).Select(qn => qn as QueryNameAttribute).FirstOrDefault();
            if (queryName != null)
            {
                Field<ListGraphType<BundleGraphType>>(
                    queryName,
                    arguments: new QueryArguments(
                        new QueryArgument<GuidGraphType> { Name = "id", DefaultValue = null }
                    ),
                    resolve: context =>
                    _entityRepositoryProvider.GetRepository<BundleEntity>().SearchAsync(new SearchEntityArguments
                    {
                        Id = context.GetArgument<Guid>("id"),
                    }));
            }
        }
    }
}
