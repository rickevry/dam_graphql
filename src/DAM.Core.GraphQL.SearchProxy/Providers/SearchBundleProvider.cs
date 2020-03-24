using DAM.Core.GraphQL.SearchProxy.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.SearchProxy.Providers
{
    public class SearchBundleProvider : SearchProviderBase, ISearchProvider
    {
        public SearchBundleProvider(IOptions<SearchProxySettings> settings) : base(settings)
        {
        }

        public Task<string> Search(string queryParams, string token)
            => Search(_settings.Value.BundleUrl, queryParams, token);
    }
}
