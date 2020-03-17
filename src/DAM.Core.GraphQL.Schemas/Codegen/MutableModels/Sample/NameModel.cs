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
    [ModelName("Name")]
    [QueryName("Name")]
    public class NameModel : MutableModel
    {
        public static implicit operator NameModel(
            Shared.Models.SampleDomain.Name entity
        )

        {
            return FromEntity(entity);
        }

        public static NameModel
        FromEntity(Shared.Models.SampleDomain.Name entity)
        {
            return new NameModel { Id = entity.Id };
        }

        public static List<NameModel>
        FromEntityList(List<Shared.Models.SampleDomain.Name> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (NameModel) entity).ToList();
        }
    }
}
