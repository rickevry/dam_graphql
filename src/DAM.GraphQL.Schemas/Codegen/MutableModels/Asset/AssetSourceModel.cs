//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.492Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("AssetSource")]
    [QueryName("AssetSource")]
    public class AssetSourceModel : MutableModel
    {
        public static implicit operator AssetSourceModel(
            Services.Models.Asset.AssetSource entity
        )

        {
            return FromEntity(entity);
        }

        public static AssetSourceModel
        FromEntity(Services.Models.Asset.AssetSource entity)
        {
            return new AssetSourceModel { Id = entity.Id };
        }

        public static List<AssetSourceModel>
        FromEntityList(List<Services.Models.Asset.AssetSource> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (AssetSourceModel) entity)
                .ToList();
        }
    }
}
