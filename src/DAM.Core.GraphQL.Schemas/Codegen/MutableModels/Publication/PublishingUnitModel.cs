//
//  This file was automatically generated and should not be edited.
//  2020-02-25T11:04:53.088Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Publication
{
    [ModelName("PublishingUnit")]
    [QueryName("PublishingUnit")]
    public class PublishingUnitModel : MutableModel
    {
        public static implicit operator PublishingUnitModel(
            Shared.Models.Publication.PublishingUnit entity
        )

        {
            return FromEntity(entity);
        }

        public static PublishingUnitModel
        FromEntity(Shared.Models.Publication.PublishingUnit entity)
        {
            return new PublishingUnitModel { Id = entity.Id };
        }

        public static List<PublishingUnitModel>
        FromEntityList(
            List<Shared.Models.Publication.PublishingUnit> entityList
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
