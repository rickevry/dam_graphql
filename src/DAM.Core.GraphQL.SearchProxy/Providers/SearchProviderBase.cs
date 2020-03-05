using DAM.Core.GraphQL.SearchProxy.Configuration;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.SearchProxy.Providers
{
    public abstract class SearchProviderBase
    {
        protected readonly IOptions<SearchProxySettings> _settings;

        protected SearchProviderBase(IOptions<SearchProxySettings> settings)
        {
            _settings = settings;
        }

        protected async Task<string> Search(string searchUrl, string queryParams, string token)
        {
            var searchUrlWithParams = $"{searchUrl}?token={token}&{queryParams}";

            using var httpClient = new HttpClient();
            using var response = await httpClient.GetAsync(searchUrlWithParams);

            string searchResponse = await response.Content.ReadAsStringAsync();
            return searchResponse;
        }
    }
}
