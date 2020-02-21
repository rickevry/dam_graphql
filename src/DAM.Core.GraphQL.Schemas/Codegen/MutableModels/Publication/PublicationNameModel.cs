//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:57.424Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Publication
{
    [ModelName("PublicationName")]
    [QueryName("PublicationName")]
    public class PublicationNameModel : MutableModel
    {
        public static implicit operator PublicationNameModel(
            Shared.Models.Publication.PublicationName entity
        )

        {
            return FromEntity(entity);
        }

        public static PublicationNameModel
        FromEntity(Shared.Models.Publication.PublicationName entity)
        {
            return new PublicationNameModel { Id = entity.Id };
        }

        public static List<PublicationNameModel>
        FromEntityList(
            List<Shared.Models.Publication.PublicationName> entityList
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