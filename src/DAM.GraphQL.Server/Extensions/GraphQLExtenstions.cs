using DAM.GraphQL.Schemas;
using GraphQL.Server;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DAM.GraphQL.Server.Extensions
{
    public static class GraphQLExtenstions
    {
        public static IServiceCollection AddGraphQL(this IServiceCollection services)
        {
            // Workaround until GraphQL can swap off Newtonsoft.Json and onto the new MS one.
            // Depending on whether you're using IIS or Kestrel, the code required is different
            // See: https://github.com/graphql-dotnet/graphql-dotnet/issues/1116
            services.Configure<KestrelServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });
            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            services.AddGraphQL(options =>
            {
                options.EnableMetrics = true;
                options.ExposeExceptions = true;
            });

            return services;
        }

        public static IServiceCollection AddGraphQLSchema(this IServiceCollection services)
        {
            services.AddSingleton<DataModelsQuery>();
            services.AddSingleton<DataModelsMutation>();
            services.AddSingleton<DataModelsSchema>();

            return services;
        }

        public static IServiceCollection AddGraphQLTypes(this IServiceCollection services)
        {
            foreach (var type in FindDataModelGraphTypes())
            {
                services.TryAdd(new ServiceDescriptor(type, type, ServiceLifetime.Transient));
            }

            return services;
        }

        private static IEnumerable<Type> FindDataModelGraphTypes()
        {
            var graphTypesAssembly = Assembly.GetAssembly(typeof(DataModelsSchema));
            return graphTypesAssembly.GetTypes().Where(x =>
                !x.IsAbstract &&
                typeof(IGraphType).IsAssignableFrom(x));
        }
    }
}
