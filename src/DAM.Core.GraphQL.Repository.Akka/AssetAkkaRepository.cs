using Akka.Actor;
using DAM.Core.Actors.Messages.Assets;
using DAM.Core.GraphQL.Schemas.Asset;
using DAM.Core.Infrastructure.AkkaClusterClient;
using DAM.Core.Infrastructure.AkkaClusterClient.Actors;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.Repository.Akka
{
    public class AssetActorRepository : DataRepository<AssetModel>
    {
        private readonly AkkaClusterClientSystem _clusterClient;
        private readonly IServiceProvider _provider;
        public AssetActorRepository(IServiceProvider provider)
        {
            _provider = provider;
            _clusterClient = _provider.GetRequiredService<AkkaClusterClientSystem>();
        }

        public override Task<AssetModel> CreateAsync(AssetModel entity)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public override Task<AssetModel> GetByIdAsync(Guid id)
        {
            try
            {
                var test = _clusterClient.Ask<GetAssetResponseMessage>(new GetAssetByIdMessage(id)).GetAwaiter().GetResult();

                if (test.IsSuccessful)
                    return Task.FromResult(AssetModel.FromEntity(test.AssetModel));
            }
            catch (Exception ex)
            {
                return null;
            }
            
            return null;
            
        }

        public override Task<IQueryable<AssetModel>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }

        public override Task<AssetModel> UpdateAsync(AssetModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
