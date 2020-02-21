//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:17.363Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Sample;

namespace DAM.GraphQL.Schemas.Sample
{
    [ModelName("Name")]
    [QueryName("Name")]
    public class NameModel : MutableModel
    {
        public static implicit operator NameModel(
            Services.Models.Sample.Name entity
        )

        {
            return FromEntity(entity);
        }

        public static NameModel FromEntity(Services.Models.Sample.Name entity)
        {
            return new NameModel { Id = entity.Id };
        }

        public static List<NameModel>
        FromEntityList(List<Services.Models.Sample.Name> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (NameModel) entity).ToList();
        }
    }
}
