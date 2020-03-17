﻿using DAM.Core.GraphQL.Repository;
using DAM.Core.GraphQL.Repository.Akka;
using DAM.Core.GraphQL.Repository.Fakes;
using DAM.Core.GraphQL.Schemas.AssetDomain;
using DAM.Core.GraphQL.Schemas.BundleDomain;
using Microsoft.Extensions.DependencyInjection;

namespace DAM.Core.GraphQL.Server.Extensions
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
