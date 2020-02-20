//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.735Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("AssetRole")]
    [QueryName("AssetRole")]
    public class AssetRoleModel : MutableModel
    {
        public static implicit operator AssetRoleModel(
            Services.Models.Asset.AssetRole entity
        )

        {
            return FromEntity(entity);
        }

        public static AssetRoleModel
        FromEntity(Services.Models.Asset.AssetRole entity)
        {
            return new AssetRoleModel { Id = entity.Id };
        }

        public static List<AssetRoleModel>
        FromEntityList(List<Services.Models.Asset.AssetRole> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (AssetRoleModel) entity)
                .ToList();
        }
    }
}
