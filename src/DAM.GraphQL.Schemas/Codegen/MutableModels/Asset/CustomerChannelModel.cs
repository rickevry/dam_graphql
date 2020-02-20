//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.761Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("CustomerChannel")]
    [QueryName("CustomerChannel")]
    public class CustomerChannelModel : MutableModel
    {
        public static implicit operator CustomerChannelModel(
            Services.Models.Asset.CustomerChannel entity
        )

        {
            return FromEntity(entity);
        }

        public static CustomerChannelModel
        FromEntity(Services.Models.Asset.CustomerChannel entity)
        {
            return new CustomerChannelModel { Id = entity.Id };
        }

        public static List<CustomerChannelModel>
        FromEntityList(List<Services.Models.Asset.CustomerChannel> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (CustomerChannelModel) entity)
                .ToList();
        }
    }
}
