//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:17.191Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Asset;

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
