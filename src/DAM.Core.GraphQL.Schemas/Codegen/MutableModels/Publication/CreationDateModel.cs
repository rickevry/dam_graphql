//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:57.866Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Publication
{
    [ModelName("CreationDate")]
    [QueryName("CreationDate")]
    public class CreationDateModel : MutableModel
    {
        public static implicit operator CreationDateModel(
            Shared.Models.Publication.CreationDate entity
        )

        {
            return FromEntity(entity);
        }

        public static CreationDateModel
        FromEntity(Shared.Models.Publication.CreationDate entity)
        {
            return new CreationDateModel { Id = entity.Id };
        }

        public static List<CreationDateModel>
        FromEntityList(List<Shared.Models.Publication.CreationDate> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (CreationDateModel) entity)
                .ToList();
        }
    }
}
