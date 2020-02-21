//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:16.847Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Publication;

namespace DAM.GraphQL.Schemas.Publication
{
    [ModelName("Name")]
    [QueryName("Name")]
    public class NameModel : MutableModel
    {
        public static implicit operator NameModel(
            Services.Models.Publication.Name entity
        )

        {
            return FromEntity(entity);
        }

        public static NameModel
        FromEntity(Services.Models.Publication.Name entity)
        {
            return new NameModel { Id = entity.Id };
        }

        public static List<NameModel>
        FromEntityList(List<Services.Models.Publication.Name> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (NameModel) entity).ToList();
        }
    }
}
