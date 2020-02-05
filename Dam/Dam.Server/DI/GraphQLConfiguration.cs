using Dam.Schemas;
using Dam.Schemas.GraphTypes.Bundle;
using GraphQL.Server;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Dam.Server
{
    public static class GraphQLConfiguration
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


            services.AddTransient<DamQuery>();
            services.AddTransient<DamMutation>();
            services.AddTransient<DamSchema>();

            services.AddGraphQL(options =>
            {
                options.EnableMetrics = true;
                options.ExposeExceptions = true;
            });

            //TODO: refactor for reflection
            services.AddTransient<BundleGraphType>();
            services.AddTransient<VersionGraphType>();
            services.AddTransient<AttachmentGraphType>();

            services.AddTransient<BundleInputGraphType>();
            services.AddTransient<VersionInputGraphType>();
            services.AddTransient<AttachmentInputGraphType>();

            return services;
        }
    }
}
