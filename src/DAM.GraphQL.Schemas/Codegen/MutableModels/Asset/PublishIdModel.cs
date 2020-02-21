//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.409Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("PublishId")]
    [QueryName("PublishId")]
    public class PublishIdModel : MutableModel
    {
        public static implicit operator PublishIdModel(
            Services.Models.Asset.PublishId entity
        )

        {
            return FromEntity(entity);
        }

        public static PublishIdModel
        FromEntity(Services.Models.Asset.PublishId entity)
        {
            return new PublishIdModel { Id = entity.Id };
        }

        public static List<PublishIdModel>
        FromEntityList(List<Services.Models.Asset.PublishId> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (PublishIdModel) entity)
                .ToList();
        }
    }
}
