using DAM.Core.GraphQL.Repository;
using DAM.Core.GraphQL.Schemas;
using DAM.Core.GraphQL.Schemas.Asset;
using DAM.Core.GraphQL.Schemas.Bundle;
using DAM.Core.GraphQL.SearchProxy.Schemas;
using DAM.Core.GraphQL.SearchProxy.Services;
using GraphQL;
using GraphQL.Types;
using GraphQL.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.Configuration
{
    public class GraphQLQuery : ObjectGraphType
    {
        private readonly DataRepositoryProvider _repositoryProvider;
        private readonly SearchClientService _searchClient;

        public GraphQLQuery(
            DataRepositoryProvider repositoryProvider,
            SearchClientService searchClient)
        {
            _repositoryProvider = repositoryProvider;
            _searchClient = searchClient;

            CreateQueryFields();
            CreateTestFields();

            _searchClient.CreateSearchFields(this);
        }

        private void CreateTestFields()
        {
            GraphTypeTypeRegistry.Register<SearchItem, SearchItemInterface>();
            GraphTypeTypeRegistry.Register<InvoiceModel, InvoiceGraphType>();
            GraphTypeTypeRegistry.Register<DrawingModel, DrawingGraphType>();

            Field<ListGraphType<WrapperGraphType>>("wrapper",
                resolve: context =>
                {
                    return Task.FromResult(
                        new List<object>
                        {
                            new InvoiceModel
                            {
                                Title="Invoice 101",
                                Customer="Volvo",
                                Amount=10000,
                            },
                            new InvoiceModel
                            {
                                Title="Invoice 102",
                                Customer="Volvo",
                                Amount=10000,
                            },
                            new DrawingModel
                            {
                                Title="SKF001",
                                Info="Lorem ipsum dolor sit amet",
                            },
                            new DrawingModel
                            {
                                Title="SKF002",
                                Info="Lorem ipsum dolor sit amet",
                            }
                        });
                });

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
