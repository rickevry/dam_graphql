//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.228Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Publication
{
    [ModelName("PublicationId")]
    [QueryName("PublicationId")]
    public class PublicationIdModel : MutableModel
    {
        public static implicit operator PublicationIdModel(
            Services.Models.Publication.PublicationId entity
        )

        {
            return FromEntity(entity);
        }

        public static PublicationIdModel
        FromEntity(Services.Models.Publication.PublicationId entity)
        {
            return new PublicationIdModel { Id = entity.Id };
        }

        public static List<PublicationIdModel>
        FromEntityList(
            List<Services.Models.Publication.PublicationId> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (PublicationIdModel) entity)
                .ToList();
        }
    }
}
