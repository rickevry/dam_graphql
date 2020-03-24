using DAM.Core.GraphQL.SearchProxy.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.SearchProxy.Providers
{
    public class SearchCollectionProvider : SearchProviderBase, ISearchProvider
    {
        public SearchCollectionProvider(IOptions<SearchProxySettings> settings) : base(settings)
        {
        }

        public Task<string> Search(string queryParams, string token)
            => Search(_settings.Value.CollectionUrl, queryParams, token);
    }
}
