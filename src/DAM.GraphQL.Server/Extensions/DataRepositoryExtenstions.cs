using DAM.GraphQL.Repository;
using DAM.GraphQL.Repository.Actors;
using DAM.GraphQL.Repository.Fakes;
using DAM.GraphQL.Schemas.Asset;
using DAM.GraphQL.Schemas.Bundle;
using Microsoft.Extensions.DependencyInjection;

namespace DAM.GraphQL.Server.Extensions
{
    public static class DataRepositoryExtenstions
    {
        public static IServiceCollection AddDataRepositories(this IServiceCollection services)
        {
            services.AddSingleton<DataRepository<AssetModel>, AssetActorRepository>();
            services.AddSingleton<DataRepository<BundleModel>, FakeBundleRepository>();

            services.AddSingleton<DataRepositoryProvider>();

            return services;
        }
    }
}
