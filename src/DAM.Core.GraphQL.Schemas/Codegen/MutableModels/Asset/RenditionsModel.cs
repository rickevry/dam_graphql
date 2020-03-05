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
    [ModelName("Renditions")]
    [QueryName("renditions")]
    public class RenditionsModel : MutableModel
    {
        private string _snapshot;

        private long _fileSize;

        private string _renditionType;

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
                _snapshot = entity.Snapshot,
                _fileSize = entity.FileSize,
                _renditionType = entity.RenditionType
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
