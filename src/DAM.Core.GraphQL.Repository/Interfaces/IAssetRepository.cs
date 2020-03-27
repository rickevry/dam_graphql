using DAM.Core.GraphQL.Schemas.AssetDomain;
using DAM.Core.Shared.Models.AssetDomain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.Repository
{
    public interface IAssetRepository : IDataRepository<AssetModel>
    {
        Task<List<Asset>> GetAssetsInFolderAsync(Guid folderId);

        Task<AssetModel> CreateInFolderAsync(AssetModel entity, Guid folderId);
    }
}
