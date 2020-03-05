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
