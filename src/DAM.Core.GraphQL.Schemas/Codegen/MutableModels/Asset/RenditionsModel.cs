//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:58.958Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    [ModelName("Renditions")]
    [QueryName("Renditions")]
    public class RenditionsModel : MutableModel
    {
        private string _renditionType;

        private string _snapshot;

        private long _fileSize;

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

        public long FileSize
        {
            get
            {
                return _fileSize;
            }
            set
            {
                SetField(ref _fileSize, value);
            }
        }

        public static implicit operator RenditionsModel(
            Shared.Models.Asset.Renditions entity
        )

        {
            return FromEntity(entity);
        }

        public static RenditionsModel
        FromEntity(Shared.Models.Asset.Renditions entity)
        {
            return new RenditionsModel {
                Id = entity.Id,
                _renditionType = entity.RenditionType,
                _snapshot = entity.Snapshot,
                _fileSize = entity.FileSize
            };
        }

        public static List<RenditionsModel>
        FromEntityList(List<Shared.Models.Asset.Renditions> entityList)
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
