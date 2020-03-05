//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.Sample;

namespace DAM.Core.GraphQL.Schemas.Sample
{
    [ModelName("Isocode")]
    [QueryName("Isocode")]
    public class IsocodeModel : MutableModel
    {
        public static implicit operator IsocodeModel(
            Shared.Models.Sample.Isocode entity
        )

        {
            return FromEntity(entity);
        }

        public static IsocodeModel
        FromEntity(Shared.Models.Sample.Isocode entity)
        {
            return new IsocodeModel { Id = entity.Id };
        }

        public static List<IsocodeModel>
        FromEntityList(List<Shared.Models.Sample.Isocode> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (IsocodeModel) entity).ToList();
        }
    }
}
