using DAM.Core.GraphQL.Schemas.FolderDomain;
using DAM.Core.Shared.Models.FolderDomain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.Repository
{
    public interface IFolderRepository : IDataRepository<FolderModel>
    {
        Task<List<Folder>> GetFoldersByWorkspaceIdAsync(Guid workspaceId);

        Task<FolderModel> UpdateFolderTitleAsync(Guid folderId, string title);
    }
}
