using DAM.Core.GraphQL.SearchProxy.Configuration;
using DAM.Core.GraphQL.SearchProxy.Converters;
using DAM.Core.GraphQL.SearchProxy.Providers;
using DAM.Core.GraphQL.SearchProxy.Schemas;
using GraphQL;
using GraphQL.Types;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.SearchProxy.Services
{
    public class SearchClientService
    {
        private readonly SearchFindProvider _findProvider;
        private readonly SearchQCProvider _qcProvider;

        private readonly QueryArguments _queryArguments = new QueryArguments(
                new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "token" },
                new QueryArgument<StringGraphType> { Name = "params" }
            );

        public SearchClientService(IOptions<SearchProxySettings> settings)
        {
            _findProvider = new SearchFindProvider(settings);
            _qcProvider = new SearchQCProvider(settings);
        }

        public async Task<RootObject> Search(ISearchProvider searchProvider, string queryParams, string token)
        {
            var searchResponse = await searchProvider.Search(queryParams, token);
            var result = DeserializeSearchResponse(searchResponse);
            return result;
        }

        public void CreateSearchFields(ObjectGraphType parent)
        {
            SearchProxyRegistration.RegisterSearchSchemaTypes();

            parent.Field<AutoRegisteringObjectGraphType<RootObject>>(
                "find",
                arguments: _queryArguments,
                resolve: ResolveSerarch(_findProvider));

            parent.Field<AutoRegisteringObjectGraphType<RootObject>>(
                "qc",
                arguments: _queryArguments,
                resolve: ResolveSerarch(_qcProvider));
        }

        private Func<IResolveFieldContext<object>, object> ResolveSerarch(ISearchProvider searchProvider)
        {
            return context =>
            {
                var token = context.GetArgument<string>("token");
                var queryParams = context.GetArgument<string>("params");

                return Search(searchProvider, queryParams, token);
            };
        }

        private static RootObject DeserializeSearchResponse(string searchResponse)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Converters.Add(new SearchResultsArrayConverter<string>());

            return JsonConvert.DeserializeObject<RootObject>(searchResponse, settings);
        }
    }
}
