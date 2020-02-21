//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.238Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("AssetId")]
    [QueryName("AssetId")]
    public class AssetIdModel : MutableModel
    {
        public static implicit operator AssetIdModel(
            Services.Models.Asset.AssetId entity
        )

        {
            return FromEntity(entity);
        }

        public static AssetIdModel
        FromEntity(Services.Models.Asset.AssetId entity)
        {
            return new AssetIdModel { Id = entity.Id };
        }

        public static List<AssetIdModel>
        FromEntityList(List<Services.Models.Asset.AssetId> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (AssetIdModel) entity).ToList();
        }
    }
}
