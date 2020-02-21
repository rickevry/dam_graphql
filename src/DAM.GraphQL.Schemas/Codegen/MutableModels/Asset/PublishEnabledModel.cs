//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.409Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("PublishEnabled")]
    [QueryName("PublishEnabled")]
    public class PublishEnabledModel : MutableModel
    {
        public static implicit operator PublishEnabledModel(
            Services.Models.Asset.PublishEnabled entity
        )

        {
            return FromEntity(entity);
        }

        public static PublishEnabledModel
        FromEntity(Services.Models.Asset.PublishEnabled entity)
        {
            return new PublishEnabledModel { Id = entity.Id };
        }

        public static List<PublishEnabledModel>
        FromEntityList(List<Services.Models.Asset.PublishEnabled> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (PublishEnabledModel) entity)
                .ToList();
        }
    }
}
