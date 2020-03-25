using DAM.Core.GraphQL.Repository;
using DAM.Core.GraphQL.Schemas;
using DAM.Core.GraphQL.Schemas.AssetDomain;
using DAM.Core.GraphQL.Schemas.BundleDomain;
using DAM.Core.GraphQL.Schemas.FolderDomain;
using DAM.Core.GraphQL.Schemas.Messages;
using DAM.Core.Messages;
using DAM.Core.Shared.Models.AssetDomain;
using DAM.Core.Shared.Models.BundleDomain;
using GraphQL;
using GraphQL.Types;
using GraphQL.Utilities;
using System;
using System.Linq;

namespace DAM.Core.GraphQL.Configuration
{
    public class GraphQLMutation : ObjectGraphType
    {
        private readonly DataRepositoryProvider _repositoryProvider;

        public GraphQLMutation(DataRepositoryProvider repositoryProvider)
        {
            _repositoryProvider = repositoryProvider;

            CreateMutableFields();
            CreateDataCommandsFields();
        }

        private void CreateMutableFields()
        {
            CreateMutableFieldsFor<AssetModel, AssetMutableGraphType, AssetInputGraphType>();
            CreateMutableFieldsFor<FolderModel, FolderMutableGraphType, FolderInputGraphType>();
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

        private void CreateDataCommandsFields()
        {
            foreach (var graphType in MessagesHelper.GetMessagesGraphTypes() ?? Enumerable.Empty<MessageTypesContainer>())
            {
                GraphTypeTypeRegistry.Register(graphType.CommandType, graphType.CommandGraphType);
                GraphTypeTypeRegistry.Register(graphType.ResultType, graphType.ResultGraphType);

                Field(
                    graphType.ResultGraphType,
                    graphType.CommandType.Name,
                    arguments: new QueryArguments(new QueryArgument(graphType.CommandGraphType)
                    {
                        Name = "command"
                    }),
                    resolve: context =>
                    {
                        var obj = context.GetArgument(graphType.CommandType, "command");
                        switch (graphType.RepositoryType)
                        {
                            case Type assetType when assetType == typeof(Asset):
                                return _repositoryProvider.GetRepository<AssetModel>().ExecuteCommand(obj as IDataCommand);
                            case Type bundleType when bundleType == typeof(Bundle):
                                return _repositoryProvider.GetRepository<BundleModel>().ExecuteCommand(obj as IDataCommand);
                        }

                        throw new NotSupportedException($"Type {graphType.RepositoryType} has no supported repository");
                    });
            }
        }
    }
}
