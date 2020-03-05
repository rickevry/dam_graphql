using DAM.Core.GraphQL.SearchProxy.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.SearchProxy.Providers
{
    public class SearchQCProvider : SearchProviderBase, ISearchProvider
    {
        public SearchQCProvider(IOptions<SearchProxySettings> settings) : base(settings)
        {
        }

        public Task<string> Search(string queryParams, string token)
            => Search(_settings.Value.QCUrl, queryParams, token);
    }
}
