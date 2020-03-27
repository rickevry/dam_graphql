using DAM.Core.GraphQL.Schemas.FolderDomain;
using DAM.Core.Infrastructure.AkkaClusterClient;
using DAM.Core.Messages;
using DAM.Core.Messages.FolderDomain;
using DAM.Core.Shared.Models.FolderDomain;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.Repository.Akka
{
    public class FolderActorRepository : DataRepository<FolderModel>, IFolderRepository
    {
        private readonly AkkaClusterClientSystem _clusterClient;
        private readonly IServiceProvider _provider;

        public FolderActorRepository(IServiceProvider provider)
        {
            _provider = provider;
            _clusterClient = _provider.GetRequiredService<AkkaClusterClientSystem>();
        }

        public override async Task<FolderModel> CreateAsync(FolderModel entity)
        {
            try
            {
                var folderResult = await _clusterClient.Ask<CreateFolderResult>(new CreateFolderCommand(entity));
                return folderResult.FolderModel;
            }
            catch
            {
                return null;
            }
        }

        public override async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                var folderResult = await _clusterClient.Ask<DeleteFolderResult>(new DeleteFolderCommand(id));
                return folderResult.IsSuccessful;
            }
            catch
            {
                return false;
            }
        }

        public override IDataResult ExecuteCommand(IDataCommand command)
        {
            throw new NotImplementedException();
        }

        public override async Task<FolderModel> GetByIdAsync(Guid id)
        {
            try
            {
                var folderResult = await _clusterClient.Ask<GetFolderByIdResult>(new GetFolderByIdCommand(id, true));
                return folderResult.FolderModel;
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<Folder>> GetFoldersByWorkspaceIdAsync(Guid workspaceId)
        {
            try
            {
                var akkaResult = await _clusterClient.Ask<GetFoldersByWorkspaceIdResult>(new GetFoldersByWorkspaceIdCommand(workspaceId, true));
                return akkaResult.Folders;
            }
            catch
            {
                return null;
            }
        }

        public override Task<IQueryable<FolderModel>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }

        public override async Task<FolderModel> UpdateAsync(FolderModel entity)
        {
            try
            {
                var folderResult = await _clusterClient.Ask<UpdateFolderResult>(new UpdateFolderCommand(entity));
                return folderResult.FolderModel;
            }
            catch
            {
                return null;
            }
        }

        public async Task<FolderModel> UpdateFolderTitleAsync(Guid folderId, string title)
        {
            try
            {
                var folderModel = await GetByIdAsync(folderId);
                folderModel.Title = title;

                return await UpdateAsync(folderModel);
            }
            catch
            {
                return null;
            }
        }
    }
}
