//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:17.394Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Sample;

namespace DAM.GraphQL.Schemas.Sample
{
    [ModelName("Type")]
    [QueryName("Type")]
    public class TypeModel : MutableModel
    {
        public static implicit operator TypeModel(
            Services.Models.Sample.Type entity
        )

        {
            return FromEntity(entity);
        }

        public static TypeModel FromEntity(Services.Models.Sample.Type entity)
        {
            return new TypeModel { Id = entity.Id };
        }

        public static List<TypeModel>
        FromEntityList(List<Services.Models.Sample.Type> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (TypeModel) entity).ToList();
        }
    }
}
