//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:16.941Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Publication;

namespace DAM.GraphQL.Schemas.Publication
{
    [ModelName("CreationDate")]
    [QueryName("CreationDate")]
    public class CreationDateModel : MutableModel
    {
        public static implicit operator CreationDateModel(
            Services.Models.Publication.CreationDate entity
        )

        {
            return FromEntity(entity);
        }

        public static CreationDateModel
        FromEntity(Services.Models.Publication.CreationDate entity)
        {
            return new CreationDateModel { Id = entity.Id };
        }

        public static List<CreationDateModel>
        FromEntityList(
            List<Services.Models.Publication.CreationDate> entityList
        )
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
