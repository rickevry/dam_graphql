//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.437Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("PublishingChannelStates")]
    [QueryName("PublishingChannelStates")]
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
            Services.Models.Asset.PublishingChannelStates entity
        )

        {
            return FromEntity(entity);
        }

        public static PublishingChannelStatesModel
        FromEntity(Services.Models.Asset.PublishingChannelStates entity)
        {
            return new PublishingChannelStatesModel {
                Id = entity.Id,
                _channel = entity.Channel,
                _state = entity.State
            };
        }

        public static List<PublishingChannelStatesModel>
        FromEntityList(
            List<Services.Models.Asset.PublishingChannelStates> entityList
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
