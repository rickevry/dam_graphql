//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:17.160Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Asset;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("Channel")]
    [QueryName("Channel")]
    public class ChannelModel : MutableModel
    {
        public static implicit operator ChannelModel(
            Services.Models.Asset.Channel entity
        )

        {
            return FromEntity(entity);
        }

        public static ChannelModel
        FromEntity(Services.Models.Asset.Channel entity)
        {
            return new ChannelModel { Id = entity.Id };
        }

        public static List<ChannelModel>
        FromEntityList(List<Services.Models.Asset.Channel> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (ChannelModel) entity).ToList();
        }
    }
}
