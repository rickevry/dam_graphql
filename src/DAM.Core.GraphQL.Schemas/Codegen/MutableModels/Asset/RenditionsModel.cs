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

        private string _mimeType;

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

        /// <summary>
        /// Title: Mandatory
        /// Is the name that would appear online. This field will be searchable in all our channels and in external search such as Google.
        /// The naming convention to ensure proper search match should be very specific to the Asset & match the filename, No abbreviations or language codes etc
        /// Designation-Brand-Product-Name (ie. 6205 SKF Deep Groove Ball Bearing)

        /// </summary>
        public string MimeType
        {
            get
            {
                return _mimeType;
            }
            set
            {
                SetField(ref _mimeType, value);
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
                _downloadUrl = entity.DownloadUrl,
                _mimeType = entity.MimeType
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
    }
}
