//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:57.695Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Publication
{
    [ModelName("PublicationId")]
    [QueryName("PublicationId")]
    public class PublicationIdModel : MutableModel
    {
        public static implicit operator PublicationIdModel(
            Shared.Models.Publication.PublicationId entity
        )

        {
            return FromEntity(entity);
        }

        public static PublicationIdModel
        FromEntity(Shared.Models.Publication.PublicationId entity)
        {
            return new PublicationIdModel { Id = entity.Id };
        }

        public static List<PublicationIdModel>
        FromEntityList(List<Shared.Models.Publication.PublicationId> entityList)
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
