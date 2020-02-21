//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:17.363Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Sample;

namespace DAM.GraphQL.Schemas.Sample
{
    [ModelName("AssetType")]
    [QueryName("AssetType")]
    public class AssetTypeModel : MutableModel
    {
        public static implicit operator AssetTypeModel(
            Services.Models.Sample.AssetType entity
        )

        {
            return FromEntity(entity);
        }

        public static AssetTypeModel
        FromEntity(Services.Models.Sample.AssetType entity)
        {
            return new AssetTypeModel { Id = entity.Id };
        }

        public static List<AssetTypeModel>
        FromEntityList(List<Services.Models.Sample.AssetType> entityList)
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
