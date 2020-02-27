using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DAM.Core.GraphQL.Schemas
{
    public static class GraphQLSchemasExtensions
    {
        public static IServiceCollection AddGraphQLDataModelTypes(this IServiceCollection services)
        {
            foreach (var type in FindDataModelGraphTypes())
            {
                services.TryAdd(new ServiceDescriptor(type, type, ServiceLifetime.Transient));
            }

            return services;
        }

        private static IEnumerable<Type> FindDataModelGraphTypes()
        {
            var assembly = Assembly.GetAssembly(typeof(GraphQLSchemasExtensions));
            return assembly.GetTypes().Where(x =>
                !x.IsAbstract &&
                typeof(IGraphType).IsAssignableFrom(x));
        }
    }
}
