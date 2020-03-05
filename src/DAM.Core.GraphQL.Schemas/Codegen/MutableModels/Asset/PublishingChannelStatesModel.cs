//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.Asset;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    [ModelName("PublishingChannelStates")]
    [QueryName("publishingChannelStates")]
    public class PublishingChannelStatesModel : MutableModel
    {
        private string _channel;

        private string _state;

        public string Channel
        {
            get
            {
                return _channel;
            }
            set
            {
                SetField(ref _channel, value);
            }
        }

        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                SetField(ref _state, value);
            }
        }

        public static implicit operator PublishingChannelStatesModel(
            Shared.Models.Asset.PublishingChannelStates entity
        )

        {
            return FromEntity(entity);
        }

        public static PublishingChannelStatesModel
        FromEntity(Shared.Models.Asset.PublishingChannelStates entity)
        {
            return new PublishingChannelStatesModel {
                Id = entity.Id,
                _channel = entity.Channel,
                _state = entity.State
            };
        }

        public static List<PublishingChannelStatesModel>
        FromEntityList(
            List<Shared.Models.Asset.PublishingChannelStates> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (PublishingChannelStatesModel) entity)
                .ToList();
        }
    }
}
