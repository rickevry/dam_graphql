//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.Publication;

namespace DAM.Core.GraphQL.Schemas.Publication
{
    [ModelName("AssetType")]
    [QueryName("AssetType")]
    public class AssetTypeModel : MutableModel
    {
        public static implicit operator AssetTypeModel(
            Shared.Models.Publication.AssetType entity
        )

        {
            return FromEntity(entity);
        }

        public static AssetTypeModel
        FromEntity(Shared.Models.Publication.AssetType entity)
        {
            return new AssetTypeModel { Id = entity.Id };
        }

        public static List<AssetTypeModel>
        FromEntityList(List<Shared.Models.Publication.AssetType> entityList)
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
