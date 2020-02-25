using DAM.Core.GraphQL.Server.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DAM.Core.GraphQL.Server.Extensions
{
    public static class ConfigurationExtensions
    {
        public static IServiceCollection AddConfiguration(this IServiceCollection services,
            IConfiguration config)
        {
            services.Configure<GraphQLConfiguration>(config);

            return services;
        }
    }
}