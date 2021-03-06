//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:16.925Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Publication;

namespace DAM.GraphQL.Schemas.Publication
{
    [ModelName("ExternalDescription")]
    [QueryName("ExternalDescription")]
    public class ExternalDescriptionModel : MutableModel
    {
        public static implicit operator ExternalDescriptionModel(
            Services.Models.Publication.ExternalDescription entity
        )

        {
            return FromEntity(entity);
        }

        public static ExternalDescriptionModel
        FromEntity(Services.Models.Publication.ExternalDescription entity)
        {
            return new ExternalDescriptionModel { Id = entity.Id };
        }

        public static List<ExternalDescriptionModel>
        FromEntityList(
            List<Services.Models.Publication.ExternalDescription> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (ExternalDescriptionModel) entity)
                .ToList();
        }
    }
}
