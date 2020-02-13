using DAM.Core.DataModels.Bundle;
using DAM.GraphQL.Repository;
using DAM.GraphQL.Repository.Fakes;
using Microsoft.Extensions.DependencyInjection;

namespace DAM.GraphQL.Server.Extensions
{
    public static class DataRepositoryExtenstions
    {
        public static IServiceCollection AddDataRepositories(this IServiceCollection services)
        {
            services.AddSingleton<DataRepository<BundleModel>, FakeBundleRepository>();
            services.AddSingleton<DataRepositoryProvider>();

            return services;
        }
    }
}
