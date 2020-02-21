//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.369Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("Renditions")]
    [QueryName("Renditions")]
    public class RenditionsModel : MutableModel
    {
        private string _renditionType;

        private string _renditionBlob;

        private string _snapshot;

        public string RenditionType
        {
            get
            {
                return _renditionType;
            }
            set
            {
                SetField(ref _renditionType, value);
            }
        }

        public string RenditionBlob
        {
            get
            {
                return _renditionBlob;
            }
            set
            {
                SetField(ref _renditionBlob, value);
            }
        }

        /// <summary>
        /// description missing
        /// </summary>
        public string Snapshot
        {
            get
            {
                return _snapshot;
            }
            set
            {
                SetField(ref _snapshot, value);
            }
        }

        public static implicit operator RenditionsModel(
            Services.Models.Asset.Renditions entity
        )

        {
            return FromEntity(entity);
        }

        public static RenditionsModel
        FromEntity(Services.Models.Asset.Renditions entity)
        {
            return new RenditionsModel {
                Id = entity.Id,
                _renditionType = entity.RenditionType,
                _renditionBlob = entity.RenditionBlob,
                _snapshot = entity.Snapshot
            };
        }

        public static List<RenditionsModel>
        FromEntityList(List<Services.Models.Asset.Renditions> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (RenditionsModel) entity)
                .ToList();
        }
    }
}
