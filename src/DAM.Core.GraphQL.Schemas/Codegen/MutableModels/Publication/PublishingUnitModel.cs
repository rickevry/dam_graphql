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
    [ModelName("PublishingUnit")]
    [QueryName("PublishingUnit")]
    public class PublishingUnitModel : MutableModel
    {
        public static implicit operator PublishingUnitModel(
            Shared.Models.PublicationDomain.PublishingUnit entity
        )

        {
            return FromEntity(entity);
        }

        public static PublishingUnitModel
        FromEntity(Shared.Models.PublicationDomain.PublishingUnit entity)
        {
            return new PublishingUnitModel { Id = entity.Id };
        }

        public static List<PublishingUnitModel>
        FromEntityList(
            List<Shared.Models.PublicationDomain.PublishingUnit> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (PublishingUnitModel) entity)
                .ToList();
        }
    }
}
