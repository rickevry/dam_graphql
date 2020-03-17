//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.CollectionDomain;

namespace DAM.Core.GraphQL.Schemas.CollectionDomain
{
    [ModelName("CoverAssetId")]
    [QueryName("CoverAssetId")]
    public class CoverAssetIdModel : MutableModel
    {
        public static implicit operator CoverAssetIdModel(
            Shared.Models.CollectionDomain.CoverAssetId entity
        )

        {
            return FromEntity(entity);
        }

        public static CoverAssetIdModel
        FromEntity(Shared.Models.CollectionDomain.CoverAssetId entity)
        {
            return new CoverAssetIdModel { Id = entity.Id };
        }

        public static List<CoverAssetIdModel>
        FromEntityList(
            List<Shared.Models.CollectionDomain.CoverAssetId> entityList
        )
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
