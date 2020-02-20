using DAM.GraphQL.Repository;
using DAM.GraphQL.Schemas.Asset;
using DAM.GraphQL.Schemas.Bundle;
using GraphQL;
using GraphQL.Types;
using System;
using System.Linq;

namespace DAM.GraphQL.Schemas
{
    public class DataModelsQuery : ObjectGraphType
    {
        private readonly DataRepositoryProvider _repositoryProvider;

        public DataModelsQuery(DataRepositoryProvider repositoryProvider)
        {
            _repositoryProvider = repositoryProvider;

            CreateQueryFields();
        }

        private void CreateQueryFields()
        {
            CreateQueryFieldsFor<BundleModel, BundleGraphType>();
            CreateQueryFieldsFor<AssetModel, AssetGraphType>();
        }

        private void CreateQueryFieldsFor<TModel, TGraphType>()
            where TModel : MutableModel, new()
            where TGraphType : ObjectGraphType<TModel>
        {

            var modelName = typeof(TModel).GetCustomAttributes(typeof(ModelNameAttribute), false).Select(qn => qn as ModelNameAttribute).FirstOrDefault();
            if (modelName != null)
            {
                CreateGetByIdField<TModel, TGraphType>(modelName);
            }

            var queryName = typeof(TModel).GetCustomAttributes(typeof(QueryNameAttribute), false).Select(qn => qn as QueryNameAttribute).FirstOrDefault();
            if (queryName != null)
            {
                if (queryName == modelName)
                {
                    throw new ArgumentException("The Query name cannot be same as the Model name. Query name is used to query multiple items.");
                }

                CreateQueryItemsField<TModel, TGraphType>(queryName);
            }
        }

        private void CreateQueryItemsField<TModel, TGraphType>(QueryNameAttribute queryName)
            where TModel : MutableModel, new()
            where TGraphType : ObjectGraphType<TModel>
        {
            Field<ListGraphType<TGraphType>>(
                queryName,
                resolve: context =>
                {
                    return _repositoryProvider.GetRepository<TModel>().GetItemsAsync();
                });
        }

        private void CreateGetByIdField<TModel, TGraphType>(ModelNameAttribute modelName)
            where TModel : MutableModel, new()
            where TGraphType : ObjectGraphType<TModel>
        {
            Field<TGraphType>(
                modelName,
                arguments: new QueryArguments(
                    new QueryArgument<GuidGraphType> { Name = "id", DefaultValue = null }
                ),
                resolve: context =>
                {
                    var id = context.GetArgument<Guid>("id");
                    return _repositoryProvider.GetRepository<TModel>().GetByIdAsync(id);
                });
        }
    }
}
