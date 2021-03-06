//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:16.832Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Publication;

namespace DAM.GraphQL.Schemas.Publication
{
    [ModelName("PublicationName")]
    [QueryName("PublicationName")]
    public class PublicationNameModel : MutableModel
    {
        public static implicit operator PublicationNameModel(
            Services.Models.Publication.PublicationName entity
        )

        {
            return FromEntity(entity);
        }

        public static PublicationNameModel
        FromEntity(Services.Models.Publication.PublicationName entity)
        {
            return new PublicationNameModel { Id = entity.Id };
        }

        public static List<PublicationNameModel>
        FromEntityList(
            List<Services.Models.Publication.PublicationName> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (PublicationNameModel) entity)
                .ToList();
        }
    }
}
