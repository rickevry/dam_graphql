using DAM.Core.GraphQL.SearchProxy.Configuration;
using DAM.Core.GraphQL.SearchProxy.Converters;
using DAM.Core.GraphQL.SearchProxy.Schemas;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.SearchProxy.Services
{
    public class SearchClientService
    {
        private readonly IOptions<SearchProxySettings> _settings;

        public SearchClientService(IOptions<SearchProxySettings> settings)
        {
            _settings = settings;
        }

        public async Task<RootObject> Search(string queryParams, string token)
        {
            var searchQueryUrl = CreateSearchUrl(queryParams, token);

            using var httpClient = new HttpClient();
            using var response = await httpClient.GetAsync(searchQueryUrl);

            string searchResponse = await response.Content.ReadAsStringAsync();

            return DeserializeSearchResponse(searchResponse);
        }

        private static RootObject DeserializeSearchResponse(string searchResponse)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Converters.Add(new SearchResultsListConverter<string>());

            return JsonConvert.DeserializeObject<RootObject>(searchResponse, settings);
        }

        private string CreateSearchUrl(string queryParams, string token)
            => $"{_settings.Value.Url}?token={token}&{queryParams}";
    }
}
