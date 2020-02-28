//
//  This file was automatically generated and should not be edited.
//  2020-02-28T09:54:22.689Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.Asset;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    [ModelName("DocumentState")]
    [QueryName("documentState")]
    public class DocumentStateModel : MutableModel
    {
        private string _state;

        private bool _isPublished;

        private List<PublishingChannelStatesModel> _publishingChannelStates;

        /// <summary>
        /// Working, accepted, archived, deleted
        /// </summary>
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

        /// <summary>
        /// (renamed)
        /// </summary>
        public bool IsPublished
        {
            get
            {
                return _isPublished;
            }
            set
            {
                SetField(ref _isPublished, value);
            }
        }

        /// <summary>
        /// WebPim,Tridion
        /// </summary>
        public List<PublishingChannelStatesModel> PublishingChannelStates
        {
            get
            {
                return _publishingChannelStates;
            }
            set
            {
                SetField(ref _publishingChannelStates, value);
            }
        }

        public static implicit operator DocumentStateModel(
            Shared.Models.Asset.DocumentState entity
        )

        {
            return FromEntity(entity);
        }

        public static DocumentStateModel
        FromEntity(Shared.Models.Asset.DocumentState entity)
        {
            return new DocumentStateModel {
                Id = entity.Id,
                _state = entity.State,
                _isPublished = entity.IsPublished,
                _publishingChannelStates =
                    PublishingChannelStatesModel
                        .FromEntityList(entity.PublishingChannelStates)
            };
        }

        public static List<DocumentStateModel>
        FromEntityList(List<Shared.Models.Asset.DocumentState> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (DocumentStateModel) entity)
                .ToList();
        }
    }
}
