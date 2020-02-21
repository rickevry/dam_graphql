//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:59.227Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Sample
{
    [ModelName("AssetType")]
    [QueryName("AssetType")]
    public class AssetTypeModel : MutableModel
    {
        public static implicit operator AssetTypeModel(
            Shared.Models.Sample.AssetType entity
        )

        {
            return FromEntity(entity);
        }

        public static AssetTypeModel
        FromEntity(Shared.Models.Sample.AssetType entity)
        {
            return new AssetTypeModel { Id = entity.Id };
        }

        public static List<AssetTypeModel>
        FromEntityList(List<Shared.Models.Sample.AssetType> entityList)
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
