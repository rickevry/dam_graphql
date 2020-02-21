//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:17.254Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Asset;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("TridionRestricted")]
    [QueryName("TridionRestricted")]
    public class TridionRestrictedModel : MutableModel
    {
        public static implicit operator TridionRestrictedModel(
            Services.Models.Asset.TridionRestricted entity
        )

        {
            return FromEntity(entity);
        }

        public static TridionRestrictedModel
        FromEntity(Services.Models.Asset.TridionRestricted entity)
        {
            return new TridionRestrictedModel { Id = entity.Id };
        }

        public static List<TridionRestrictedModel>
        FromEntityList(List<Services.Models.Asset.TridionRestricted> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (TridionRestrictedModel) entity)
                .ToList();
        }
    }
}
