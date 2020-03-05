//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.Collection;

namespace DAM.Core.GraphQL.Schemas.Collection
{
    [ModelName("CoverAssetId")]
    [QueryName("CoverAssetId")]
    public class CoverAssetIdModel : MutableModel
    {
        public static implicit operator CoverAssetIdModel(
            Shared.Models.Collection.CoverAssetId entity
        )

        {
            return FromEntity(entity);
        }

        public static CoverAssetIdModel
        FromEntity(Shared.Models.Collection.CoverAssetId entity)
        {
            return new CoverAssetIdModel { Id = entity.Id };
        }

        public static List<CoverAssetIdModel>
        FromEntityList(List<Shared.Models.Collection.CoverAssetId> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (CoverAssetIdModel) entity)
                .ToList();
        }
    }
}
