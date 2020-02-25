//
//  This file was automatically generated and should not be edited.
//  2020-02-25T11:04:53.760Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

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
