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
    [ModelName("Renditions")]
    [QueryName("renditions")]
    public class RenditionsModel : MutableModel
    {
        private long _fileSize;

        private string _snapshot;

        private string _renditionType;

        private string _downloadUrl;

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

        public string DownloadUrl
        {
            get
            {
                return _downloadUrl;
            }
            set
            {
                SetField(ref _downloadUrl, value);
            }
        }

        public static implicit operator RenditionsModel(
            Shared.Models.AssetDomain.Renditions entity
        )

        {
            return FromEntity(entity);
        }

        public static RenditionsModel
        FromEntity(Shared.Models.AssetDomain.Renditions entity)
        {
            return new RenditionsModel {
                Id = entity.Id,
                _fileSize = entity.FileSize,
                _snapshot = entity.Snapshot,
                _renditionType = entity.RenditionType,
                _downloadUrl = entity.DownloadUrl
            };
        }

        public static List<RenditionsModel>
        FromEntityList(List<Shared.Models.AssetDomain.Renditions> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (RenditionsModel) entity)
                .ToList();
        }

        public static implicit operator Shared.Models.AssetDomain.Renditions(
            RenditionsModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.AssetDomain.Renditions
        ToEntity(RenditionsModel model)
        {
            return new Shared.Models.AssetDomain.Renditions {
                Id = model.Id,
                FileSize = model._fileSize,
                Snapshot = model._snapshot,
                RenditionType = model._renditionType,
                DownloadUrl = model._downloadUrl
            };
        }

        public static List<Shared.Models.AssetDomain.Renditions>
        ToEntityList(List<RenditionsModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity => (Shared.Models.AssetDomain.Renditions) entity)
                .ToList();
        }
    }
}
