//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.677Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("Corporate")]
    [QueryName("Corporate")]
    public class CorporateModel : MutableModel
    {
        public static implicit operator CorporateModel(
            Services.Models.Asset.Corporate entity
        )

        {
            return FromEntity(entity);
        }

        public static CorporateModel
        FromEntity(Services.Models.Asset.Corporate entity)
        {
            return new CorporateModel { Id = entity.Id };
        }

        public static List<CorporateModel>
        FromEntityList(List<Services.Models.Asset.Corporate> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (CorporateModel) entity)
                .ToList();
        }
    }
}
