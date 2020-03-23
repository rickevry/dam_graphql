using DAM.Core.GraphQL.Configuration;
using DAM.Core.GraphQL.SearchProxy.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DAM.Core.GraphQL.Server.Extensions
{
    public static class ConfigurationExtensions
    {
        public static IServiceCollection AddConfiguration(this IServiceCollection services,
            IConfiguration config)
        {
            services.Configure<GraphQLSettings>(config.GetSection(nameof(GraphQLSettings)));
            services.Configure<SearchProxySettings>(config.GetSection(nameof(SearchProxySettings)));

            return services;
        }
    }
}