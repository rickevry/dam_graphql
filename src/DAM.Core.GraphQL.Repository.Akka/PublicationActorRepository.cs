using DAM.Core.GraphQL.Schemas.AssetDomain;
using DAM.Core.GraphQL.Schemas.PublicationDomain;
using DAM.Core.Infrastructure.AkkaClusterClient;
using DAM.Core.Messages;
using DAM.Core.Messages.AssetDomain;
using DAM.Core.Messages.PublicationDomain;
using DAM.Core.Shared.Models.AssetDomain;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.Repository.Akka
{
    public class PublicationActorRepository : DataRepository<PublicationModel>
    {
        private readonly AkkaClusterClientSystem _clusterClient;
        private readonly IServiceProvider _provider;

        public PublicationActorRepository(IServiceProvider provider)
        {
            _provider = provider;
            _clusterClient = _provider.GetRequiredService<AkkaClusterClientSystem>();
        }

        public override Task<PublicationModel> CreateAsync(PublicationModel entity)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public override IDataResult ExecuteCommand(IDataCommand command)
        {
            throw new NotImplementedException();
        }

        public override async Task<PublicationModel> GetByIdAsync(Guid id)
        {
            try
            {
                var akkaResult = await _clusterClient.Ask<GetPublicationByIdResult>(new GetPublicationByIdCommand(id));
                return akkaResult.PublicationModel;
            }
            catch
            {
                return null;
            }
        }

        public override Task<IQueryable<PublicationModel>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }

        public override Task<PublicationModel> UpdateAsync(PublicationModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
