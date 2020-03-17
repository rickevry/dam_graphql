//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.AssetDomain;

namespace DAM.Core.GraphQL.Schemas.AssetDomain
{
    [ModelName("Channel")]
    [QueryName("Channel")]
    public class ChannelModel : MutableModel
    {
        public static implicit operator ChannelModel(
            Shared.Models.AssetDomain.Channel entity
        )

        {
            return FromEntity(entity);
        }

        public static ChannelModel
        FromEntity(Shared.Models.AssetDomain.Channel entity)
        {
            return new ChannelModel { Id = entity.Id };
        }

        public static List<ChannelModel>
        FromEntityList(List<Shared.Models.AssetDomain.Channel> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (ChannelModel) entity).ToList();
        }
    }
}
