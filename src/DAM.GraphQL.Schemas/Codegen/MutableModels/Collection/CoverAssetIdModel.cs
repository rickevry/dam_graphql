//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.048Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Collection
{
    [ModelName("CoverAssetId")]
    [QueryName("CoverAssetId")]
    public class CoverAssetIdModel : MutableModel
    {
        public static implicit operator CoverAssetIdModel(
            Services.Models.Collection.CoverAssetId entity
        )

        {
            return FromEntity(entity);
        }

        public static CoverAssetIdModel
        FromEntity(Services.Models.Collection.CoverAssetId entity)
        {
            return new CoverAssetIdModel { Id = entity.Id };
        }

        public static List<CoverAssetIdModel>
        FromEntityList(List<Services.Models.Collection.CoverAssetId> entityList)
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
