//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.307Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("AssetType")]
    [QueryName("AssetType")]
    public class AssetTypeModel : MutableModel
    {
        public static implicit operator AssetTypeModel(
            Services.Models.Asset.AssetType entity
        )

        {
            return FromEntity(entity);
        }

        public static AssetTypeModel
        FromEntity(Services.Models.Asset.AssetType entity)
        {
            return new AssetTypeModel { Id = entity.Id };
        }

        public static List<AssetTypeModel>
        FromEntityList(List<Services.Models.Asset.AssetType> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (AssetTypeModel) entity)
                .ToList();
        }
    }
}
