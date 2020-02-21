//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:57.502Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Publication
{
    [ModelName("Name")]
    [QueryName("Name")]
    public class NameModel : MutableModel
    {
        public static implicit operator NameModel(
            Shared.Models.Publication.Name entity
        )

        {
            return FromEntity(entity);
        }

        public static NameModel
        FromEntity(Shared.Models.Publication.Name entity)
        {
            return new NameModel { Id = entity.Id };
        }

        public static List<NameModel>
        FromEntityList(List<Shared.Models.Publication.Name> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (NameModel) entity).ToList();
        }
    }
}
