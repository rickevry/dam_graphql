﻿using DAM.Core.GraphQL.Schemas;
using DAM.Core.GraphQL.SearchProxy;
using DAM.Core.GraphQL.Server.Configuration;
using GraphQL.Server;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace DAM.Core.GraphQL.Server.Extensions
{
    public static class GraphQLExtenstions
    {
        public static IServiceCollection AddGraphQLService(this IServiceCollection services)
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

            services.AddGraphQL((provider, options) =>
            {
                var settings = provider.GetRequiredService<IOptions<GraphQLSettings>>().Value;

                options.EnableMetrics = settings.EnableMetrics;
                options.ExposeExceptions = settings.ExposeExceptions;
            })
                .AddSystemTextJson(deserializerSettings => { }, serializerSettings => { });

            return services;
        }

        public static IServiceCollection AddGraphQLSchema(this IServiceCollection services)
        {
            services.AddSingleton<GraphQLQuery>();
            services.AddSingleton<GraphQLMutation>();
            services.AddSingleton<GraphQLSchema>();

            return services;
        }

        public static IServiceCollection AddGraphQLTypes(this IServiceCollection services)
        {
            return services
                .AddGraphQLSearchProxyTypes()
                .AddGraphQLDataModelTypes();
        }
    }
}
