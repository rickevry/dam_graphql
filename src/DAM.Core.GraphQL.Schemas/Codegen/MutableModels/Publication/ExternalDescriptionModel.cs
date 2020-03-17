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
    [ModelName("ExternalDescription")]
    [QueryName("ExternalDescription")]
    public class ExternalDescriptionModel : MutableModel
    {
        public static implicit operator ExternalDescriptionModel(
            Shared.Models.PublicationDomain.ExternalDescription entity
        )

        {
            return FromEntity(entity);
        }

        public static ExternalDescriptionModel
        FromEntity(Shared.Models.PublicationDomain.ExternalDescription entity)
        {
            return new ExternalDescriptionModel { Id = entity.Id };
        }

        public static List<ExternalDescriptionModel>
        FromEntityList(
            List<Shared.Models.PublicationDomain.ExternalDescription> entityList
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
