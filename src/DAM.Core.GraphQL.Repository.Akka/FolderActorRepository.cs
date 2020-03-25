using DAM.Core.GraphQL.Schemas.FolderDomain;
using DAM.Core.Infrastructure.AkkaClusterClient;
using DAM.Core.Messages;
using DAM.Core.Messages.FolderDomain;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.Repository.Akka
{
    public class FolderActorRepository : DataRepository<FolderModel>
    {
        private readonly AkkaClusterClientSystem _clusterClient;
        private readonly IServiceProvider _provider;

        public FolderActorRepository(IServiceProvider provider)
        {
            _provider = provider;
            _clusterClient = _provider.GetRequiredService<AkkaClusterClientSystem>();
        }

        public override Task<FolderModel> CreateAsync(FolderModel entity)
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

        public override Task<FolderModel> GetByIdAsync(Guid id)
        {
            try
            {
                var akkaResult = _clusterClient.Ask<GetFolderResult>(new GetFolderByIdCommand(id, true)).GetAwaiter().GetResult();

                if (akkaResult.IsSuccessful)
                    return Task.FromResult(FolderModel.FromEntity(akkaResult.FolderModel));
            }
            catch
            {
            }

            return null;

        }

        public override Task<IQueryable<FolderModel>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }

        public override Task<FolderModel> UpdateAsync(FolderModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
