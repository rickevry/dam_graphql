using Microsoft.Extensions.DependencyInjection;

namespace DAM.Core.GraphQL.Configuration
{
    public static class GraphQLTestExtensions
    {
        public static IServiceCollection AddGraphQLTestTypes(this IServiceCollection services)
        {
            services.AddTransient<InvoiceGraphType>();
            services.AddTransient<DrawingGraphType>();
            services.AddTransient<WrapperGraphType>();

            return services;
        }
    }
}
