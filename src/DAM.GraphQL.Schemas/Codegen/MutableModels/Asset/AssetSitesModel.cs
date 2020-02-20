//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.779Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("AssetSites")]
    [QueryName("AssetSites")]
    public class AssetSitesModel : MutableModel
    {
        public static implicit operator AssetSitesModel(
            Services.Models.Asset.AssetSites entity
        )

        {
            return FromEntity(entity);
        }

        public static AssetSitesModel
        FromEntity(Services.Models.Asset.AssetSites entity)
        {
            return new AssetSitesModel { Id = entity.Id };
        }

        public static List<AssetSitesModel>
        FromEntityList(List<Services.Models.Asset.AssetSites> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (AssetSitesModel) entity)
                .ToList();
        }
    }
}
