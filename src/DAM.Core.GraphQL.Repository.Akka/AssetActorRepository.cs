﻿using DAM.Core.GraphQL.Schemas.AssetDomain;
using DAM.Core.Infrastructure.AkkaClusterClient;
using DAM.Core.Messages;
using DAM.Core.Messages.AssetDomain;
using DAM.Core.Shared.Models.AssetDomain;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.Repository.Akka
{
    public class AssetActorRepository : DataRepository<AssetModel>, IAssetRepository
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

        public override IDataResult ExecuteCommand(IDataCommand command)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Asset>> GetAssetsInFolderAsync(Guid folderId)
        {
            try
            {
                var akkaResult = await _clusterClient.Ask<GetAssetsInFolderResult>(new GetAssetsInFolderCommand(folderId));
                return akkaResult.Assets;
            }
            catch
            {
                return null;
            }
        }

        public override async Task<AssetModel> GetByIdAsync(Guid id)
        {
            try
            {
                var akkaResult = await _clusterClient.Ask<GetAssetByIdResult>(new GetAssetByIdCommand(id));
                return AssetModel.FromEntity(akkaResult.AssetModel);
            }
            catch
            {
                return null;
            }
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
