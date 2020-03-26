using DAM.Core.Shared.Models.AssetDomain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.Repository
{
    public interface IAssetRepository
    {
        Task<List<Asset>> GetAssetsInFolderAsync(Guid folderId);
    }
}
