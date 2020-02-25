//
//  This file was automatically generated and should not be edited.
//  2020-02-25T11:04:53.932Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Sample
{
    [ModelName("Type")]
    [QueryName("Type")]
    public class TypeModel : MutableModel
    {
        public static implicit operator TypeModel(
            Shared.Models.Sample.Type entity
        )

        {
            return FromEntity(entity);
        }

        public static TypeModel FromEntity(Shared.Models.Sample.Type entity)
        {
            return new TypeModel { Id = entity.Id };
        }

        public static List<TypeModel>
        FromEntityList(List<Shared.Models.Sample.Type> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (TypeModel) entity).ToList();
        }
    }
}
