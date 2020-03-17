//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.PublicationDomain;

namespace DAM.Core.GraphQL.Schemas.PublicationDomain
{
    [ModelName("PublicationName")]
    [QueryName("PublicationName")]
    public class PublicationNameModel : MutableModel
    {
        public static implicit operator PublicationNameModel(
            Shared.Models.PublicationDomain.PublicationName entity
        )

        {
            return FromEntity(entity);
        }

        public static PublicationNameModel
        FromEntity(Shared.Models.PublicationDomain.PublicationName entity)
        {
            return new PublicationNameModel { Id = entity.Id };
        }

        public static List<PublicationNameModel>
        FromEntityList(
            List<Shared.Models.PublicationDomain.PublicationName> entityList
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
