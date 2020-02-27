using DAM.Core.GraphQL.SearchProxy.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DAM.Core.GraphQL.Server.Extensions
{
    public static class IntegrationClientsExtensions
    {
        public static IServiceCollection AddIntegrationClients(this IServiceCollection services)
        {
            services.AddSingleton<SearchClientService>();

            return services;
        }
    }
}
