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
    [ModelName("PublishingUnit")]
    [QueryName("PublishingUnit")]
    public class PublishingUnitModel : MutableModel
    {
        public static implicit operator PublishingUnitModel(
            Services.Models.Publication.PublishingUnit entity
        )

        {
            return FromEntity(entity);
        }

        public static PublishingUnitModel
        FromEntity(Services.Models.Publication.PublishingUnit entity)
        {
            return new PublishingUnitModel { Id = entity.Id };
        }

        public static List<PublishingUnitModel>
        FromEntityList(
            List<Services.Models.Publication.PublishingUnit> entityList
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
