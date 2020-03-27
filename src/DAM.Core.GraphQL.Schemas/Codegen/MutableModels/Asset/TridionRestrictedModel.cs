//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.AssetDomain;

namespace DAM.Core.GraphQL.Schemas.AssetDomain
{
    [ModelName("TridionRestricted")]
    [QueryName("TridionRestricted")]
    public class TridionRestrictedModel : MutableModel
    {
        public static implicit operator TridionRestrictedModel(
            Shared.Models.AssetDomain.TridionRestricted entity
        )

        {
            return FromEntity(entity);
        }

        public static TridionRestrictedModel
        FromEntity(Shared.Models.AssetDomain.TridionRestricted entity)
        {
            return new TridionRestrictedModel { Id = entity.Id };
        }

        public static List<TridionRestrictedModel>
        FromEntityList(
            List<Shared.Models.AssetDomain.TridionRestricted> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (TridionRestrictedModel) entity)
                .ToList();
        }

        public
        static implicit operator Shared.Models.AssetDomain.TridionRestricted(
            TridionRestrictedModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.AssetDomain.TridionRestricted
        ToEntity(TridionRestrictedModel model)
        {
            return new Shared.Models.AssetDomain.TridionRestricted {
                Id = model.Id
            };
        }

        public static List<Shared.Models.AssetDomain.TridionRestricted>
        ToEntityList(List<TridionRestrictedModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity =>
                    (Shared.Models.AssetDomain.TridionRestricted) entity)
                .ToList();
        }
    }
}
