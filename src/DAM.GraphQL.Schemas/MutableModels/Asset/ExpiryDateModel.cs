//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:17.175Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Asset;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("ExpiryDate")]
    [QueryName("ExpiryDate")]
    public class ExpiryDateModel : MutableModel
    {
        public static implicit operator ExpiryDateModel(
            Services.Models.Asset.ExpiryDate entity
        )

        {
            return FromEntity(entity);
        }

        public static ExpiryDateModel
        FromEntity(Services.Models.Asset.ExpiryDate entity)
        {
            return new ExpiryDateModel { Id = entity.Id };
        }

        public static List<ExpiryDateModel>
        FromEntityList(List<Services.Models.Asset.ExpiryDate> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (ExpiryDateModel) entity)
                .ToList();
        }
    }
}
