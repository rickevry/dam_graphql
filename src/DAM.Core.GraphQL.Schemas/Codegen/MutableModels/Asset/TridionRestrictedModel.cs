//
//  This file was automatically generated and should not be edited.
//  2020-02-28T09:54:23.008Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.Asset;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    [ModelName("TridionRestricted")]
    [QueryName("TridionRestricted")]
    public class TridionRestrictedModel : MutableModel
    {
        public static implicit operator TridionRestrictedModel(
            Shared.Models.Asset.TridionRestricted entity
        )

        {
            return FromEntity(entity);
        }

        public static TridionRestrictedModel
        FromEntity(Shared.Models.Asset.TridionRestricted entity)
        {
            return new TridionRestrictedModel { Id = entity.Id };
        }

        public static List<TridionRestrictedModel>
        FromEntityList(List<Shared.Models.Asset.TridionRestricted> entityList)
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
