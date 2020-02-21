//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.475Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("AssetTitle")]
    [QueryName("AssetTitle")]
    public class AssetTitleModel : MutableModel
    {
        public static implicit operator AssetTitleModel(
            Services.Models.Asset.AssetTitle entity
        )

        {
            return FromEntity(entity);
        }

        public static AssetTitleModel
        FromEntity(Services.Models.Asset.AssetTitle entity)
        {
            return new AssetTitleModel { Id = entity.Id };
        }

        public static List<AssetTitleModel>
        FromEntityList(List<Services.Models.Asset.AssetTitle> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (AssetTitleModel) entity)
                .ToList();
        }
    }
}
