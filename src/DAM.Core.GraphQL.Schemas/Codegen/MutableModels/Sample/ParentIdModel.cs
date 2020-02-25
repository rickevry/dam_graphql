//
//  This file was automatically generated and should not be edited.
//  2020-02-25T11:04:53.885Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Sample
{
    [ModelName("ParentId")]
    [QueryName("ParentId")]
    public class ParentIdModel : MutableModel
    {
        public static implicit operator ParentIdModel(
            Shared.Models.Sample.ParentId entity
        )

        {
            return FromEntity(entity);
        }

        public static ParentIdModel
        FromEntity(Shared.Models.Sample.ParentId entity)
        {
            return new ParentIdModel { Id = entity.Id };
        }

        public static List<ParentIdModel>
        FromEntityList(List<Shared.Models.Sample.ParentId> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (ParentIdModel) entity).ToList();
        }
    }
}
