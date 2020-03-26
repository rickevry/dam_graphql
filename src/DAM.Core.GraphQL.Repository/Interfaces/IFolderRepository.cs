using DAM.Core.Shared.Models.FolderDomain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.Repository
{
    public interface IFolderRepository
    {
        Task<List<Folder>> GetFoldersByWorkspaceIdAsync(Guid workspaceId);
    }
}
