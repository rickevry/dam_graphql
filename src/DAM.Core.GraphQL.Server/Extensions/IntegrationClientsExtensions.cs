using Microsoft.Extensions.DependencyInjection;

namespace DAM.Core.GraphQL.Server.Extensions
{
    public static class IntegrationClientsExtensions
    {
        public static IServiceCollection AddIntegrationClients(this IServiceCollection services)
        {
            return services;
        }
    }
}
