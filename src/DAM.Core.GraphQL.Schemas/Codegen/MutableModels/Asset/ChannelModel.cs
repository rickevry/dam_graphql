//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:58.083Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    [ModelName("Channel")]
    [QueryName("Channel")]
    public class ChannelModel : MutableModel
    {
        public static implicit operator ChannelModel(
            Shared.Models.Asset.Channel entity
        )

        {
            return FromEntity(entity);
        }

        public static ChannelModel
        FromEntity(Shared.Models.Asset.Channel entity)
        {
            return new ChannelModel { Id = entity.Id };
        }

        public static List<ChannelModel>
        FromEntityList(List<Shared.Models.Asset.Channel> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (ChannelModel) entity).ToList();
        }
    }
}
