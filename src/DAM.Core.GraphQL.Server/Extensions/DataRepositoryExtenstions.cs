using DAM.Core.GraphQL.Repository;
using DAM.Core.GraphQL.Repository.Akka;
using DAM.Core.GraphQL.Schemas.AssetDomain;
using DAM.Core.GraphQL.Schemas.BundleDomain;
using DAM.Core.GraphQL.Schemas.TermsetDomain;
using DAM.Core.GraphQL.Schemas.FolderDomain;
using DAM.Core.GraphQL.Schemas.PublicationDomain;
using DAM.GraphQL.Repository.Fakes;
using Microsoft.Extensions.DependencyInjection;
using DAM.Core.GraphQL.Repository.Fakes;

namespace DAM.Core.GraphQL.Server.Extensions
{
    public static class DataRepositoryExtenstions
    {
        public static IServiceCollection AddDataRepositories(this IServiceCollection services)
        {
            services.AddSingleton<DataRepository<AssetModel>, AssetActorRepository>();
            services.AddSingleton<IAssetRepository, AssetActorRepository>();

            services.AddSingleton<DataRepository<FolderModel>, FolderActorRepository>();
            services.AddSingleton<IFolderRepository, FolderActorRepository>();


            services.AddSingleton<DataRepository<TermsetModel>, FakeTermsetRepository>();
            services.AddSingleton<ITermsetRepository, FakeTermsetRepository>();
            // rickard
            


            services.AddSingleton<DataRepository<PublicationModel>, PublicationActorRepository>();

            services.AddSingleton<DataRepositoryProvider>();

            return services;
        }
    }
}
