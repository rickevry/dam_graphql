//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.512Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("AssetFileName")]
    [QueryName("AssetFileName")]
    public class AssetFileNameModel : MutableModel
    {
        public static implicit operator AssetFileNameModel(
            Services.Models.Asset.AssetFileName entity
        )

        {
            return FromEntity(entity);
        }

        public static AssetFileNameModel
        FromEntity(Services.Models.Asset.AssetFileName entity)
        {
            return new AssetFileNameModel { Id = entity.Id };
        }

        public static List<AssetFileNameModel>
        FromEntityList(List<Services.Models.Asset.AssetFileName> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (AssetFileNameModel) entity)
                .ToList();
        }
    }
}
