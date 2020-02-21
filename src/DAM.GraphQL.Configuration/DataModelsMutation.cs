using DAM.GraphQL.Repository;
using DAM.GraphQL.Schemas.Asset;
using DAM.GraphQL.Schemas.Bundle;
using GraphQL;
using GraphQL.Types;
using System;
using System.Linq;

namespace DAM.GraphQL.Schemas
{
    public class DataModelsMutation : ObjectGraphType
    {
        private readonly DataRepositoryProvider _repositoryProvider;

        public DataModelsMutation(DataRepositoryProvider repositoryProvider)
        {
            _repositoryProvider = repositoryProvider;

            CreateMutableFields();
        }

        private void CreateMutableFields()
        {
            CreateMutableFieldsFor<AssetModel, AssetGraphType, AssetInputGraphType>();
            CreateMutableFieldsFor<BundleModel, BundleGraphType, BundleInputGraphType>();
        }

        private void CreateMutableFieldsFor<TModel, TGraphType, TInputGraphType>()
            where TModel : MutableModel, new()
            where TGraphType : ObjectGraphType<TModel>
            where TInputGraphType : InputObjectGraphType<TModel>
        {
            var modelName = typeof(TModel).GetCustomAttributes(typeof(ModelNameAttribute), false).Select(qn => qn as ModelNameAttribute).FirstOrDefault();
            if (modelName != null)
            {
                CreateSaveFunctionField<TModel, TGraphType, TInputGraphType>(modelName);
                CreateDeleteFunctionField<TModel>(modelName);
            }
        }

        private void CreateDeleteFunctionField<TModel>(ModelNameAttribute modelName)
            where TModel : MutableModel, new()
        {
            Field<BooleanGraphType>(
                $"delete{modelName}",
                arguments: new QueryArguments(
                    new QueryArgument<GuidGraphType> { Name = "id", DefaultValue = null }
                ),
                resolve: context =>
                {
                    var id = context.GetArgument<Guid>("id");
                    return _repositoryProvider.GetRepository<TModel>().DeleteAsync(id);
                });
        }

        private void CreateSaveFunctionField<TModel, TGraphType, TInputGraphType>(ModelNameAttribute modelName)
            where TModel : MutableModel, new()
            where TGraphType : ObjectGraphType<TModel>
            where TInputGraphType : InputObjectGraphType<TModel>
        {
            Field<TGraphType>(
                $"save{modelName}",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<TInputGraphType>> { Name = modelName.Name.ToLower() }
                ),
                resolve: context =>
                {
                    var obj = context.GetArgument<TModel>(modelName.Name.ToLower());
                    return _repositoryProvider.GetRepository<TModel>().SaveAsync(obj);
                });
        }
    }
}
