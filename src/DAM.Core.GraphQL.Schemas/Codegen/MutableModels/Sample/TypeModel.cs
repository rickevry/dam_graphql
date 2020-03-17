//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.SampleDomain;

namespace DAM.Core.GraphQL.Schemas.SampleDomain
{
    [ModelName("Type")]
    [QueryName("Type")]
    public class TypeModel : MutableModel
    {
        public static implicit operator TypeModel(
            Shared.Models.SampleDomain.Type entity
        )

        {
            return FromEntity(entity);
        }

        public static TypeModel
        FromEntity(Shared.Models.SampleDomain.Type entity)
        {
            return new TypeModel { Id = entity.Id };
        }

        public static List<TypeModel>
        FromEntityList(List<Shared.Models.SampleDomain.Type> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (TypeModel) entity).ToList();
        }
    }
}
