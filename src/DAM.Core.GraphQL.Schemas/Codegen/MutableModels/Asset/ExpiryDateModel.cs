//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:58.389Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    [ModelName("ExpiryDate")]
    [QueryName("ExpiryDate")]
    public class ExpiryDateModel : MutableModel
    {
        public static implicit operator ExpiryDateModel(
            Shared.Models.Asset.ExpiryDate entity
        )

        {
            return FromEntity(entity);
        }

        public static ExpiryDateModel
        FromEntity(Shared.Models.Asset.ExpiryDate entity)
        {
            return new ExpiryDateModel { Id = entity.Id };
        }

        public static List<ExpiryDateModel>
        FromEntityList(List<Shared.Models.Asset.ExpiryDate> entityList)
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
