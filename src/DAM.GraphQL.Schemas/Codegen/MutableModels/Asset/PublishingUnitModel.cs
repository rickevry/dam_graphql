//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.281Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("PublishingUnit")]
    [QueryName("PublishingUnit")]
    public class PublishingUnitModel : MutableModel
    {
        public static implicit operator PublishingUnitModel(
            Services.Models.Asset.PublishingUnit entity
        )

        {
            return FromEntity(entity);
        }

        public static PublishingUnitModel
        FromEntity(Services.Models.Asset.PublishingUnit entity)
        {
            return new PublishingUnitModel { Id = entity.Id };
        }

        public static List<PublishingUnitModel>
        FromEntityList(List<Services.Models.Asset.PublishingUnit> entityList)
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
