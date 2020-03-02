using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DAM.Core.GraphQL.Configuration
{
    public static class GraphQLTestExtensions
    {
        public static IServiceCollection AddGraphQLTestTypes(this IServiceCollection services)
        {
            services.AddTransient<InvoiceGraphType>();
            services.AddTransient<DrawingGraphType>();

            return services;
        }
    }
}
