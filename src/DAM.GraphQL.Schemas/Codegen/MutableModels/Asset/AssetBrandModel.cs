//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.269Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("AssetBrand")]
    [QueryName("AssetBrand")]
    public class AssetBrandModel : MutableModel
    {
        public static implicit operator AssetBrandModel(
            Services.Models.Asset.AssetBrand entity
        )

        {
            return FromEntity(entity);
        }

        public static AssetBrandModel
        FromEntity(Services.Models.Asset.AssetBrand entity)
        {
            return new AssetBrandModel { Id = entity.Id };
        }

        public static List<AssetBrandModel>
        FromEntityList(List<Services.Models.Asset.AssetBrand> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (AssetBrandModel) entity)
                .ToList();
        }
    }
}
