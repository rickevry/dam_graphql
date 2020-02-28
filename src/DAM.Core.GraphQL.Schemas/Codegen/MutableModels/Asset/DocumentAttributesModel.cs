//
//  This file was automatically generated and should not be edited.
//  2020-02-28T09:54:22.850Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.Asset;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    [ModelName("DocumentAttributes")]
    [QueryName("documentAttributes")]
    public class DocumentAttributesModel : MutableModel
    {
        private DateTime _fileModifiedDate;

        private Guid _checkedOutBy;

        private bool _isCheckedOut;

        private DateTime _republishedDate;

        private DateTime _publishedDate;

        private string _checksum;

        private long _fileSize;

        private DateTime _metadataModifiedDate;

        private string _fileName;

        public DateTime FileModifiedDate
        {
            get
            {
                return _fileModifiedDate;
            }
            set
            {
                SetField(ref _fileModifiedDate, value);
            }
        }

        /// <summary>
        /// description missing
        /// </summary>
        public Guid CheckedOutBy
        {
            get
            {
                return _checkedOutBy;
            }
            set
            {
                SetField(ref _checkedOutBy, value);
            }
        }

        /// <summary>
        /// description missing
        /// </summary>
        public bool IsCheckedOut
        {
            get
            {
                return _isCheckedOut;
            }
            set
            {
                SetField(ref _isCheckedOut, value);
            }
        }

        public DateTime RepublishedDate
        {
            get
            {
                return _republishedDate;
            }
            set
            {
                SetField(ref _republishedDate, value);
            }
        }

        /// <summary>
        /// Publish date: Will be the date you publish your asset. It can also be pre-set to a future date if needed. Once published, the asset will not be visible untill the set future date is met.
        /// </summary>
        public DateTime PublishedDate
        {
            get
            {
                return _publishedDate;
            }
            set
            {
                SetField(ref _publishedDate, value);
            }
        }

        public string Checksum
        {
            get
            {
                return _checksum;
            }
            set
            {
                SetField(ref _checksum, value);
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

        public DateTime MetadataModifiedDate
        {
            get
            {
                return _metadataModifiedDate;
            }
            set
            {
                SetField(ref _metadataModifiedDate, value);
            }
        }

        /// <summary>
        /// File name: Is the name you give the file on your computer. This field will be searchable in all our channels and in external search such as Google.
        /// In Media Finder, photos/illustrations/Rich media/Zip the file name will appear as the title.
        /// The naming convention to ensure proper search match should be very specific to the Asset & match the set title, No abbreviations or language codes etc
        /// Designation-Brand-ProductName-industry (ie. 6205 SKF Deep Groove Ball Bearing used in food processing plant)
        /// </summary>
        public string FileName
        {
            get
            {
                return _fileName;
            }
            set
            {
                SetField(ref _fileName, value);
            }
        }

        public static implicit operator DocumentAttributesModel(
            Shared.Models.Asset.DocumentAttributes entity
        )

        {
            return FromEntity(entity);
        }

        public static DocumentAttributesModel
        FromEntity(Shared.Models.Asset.DocumentAttributes entity)
        {
            return new DocumentAttributesModel {
                Id = entity.Id,
                _fileModifiedDate = entity.FileModifiedDate,
                _checkedOutBy = entity.CheckedOutBy,
                _isCheckedOut = entity.IsCheckedOut,
                _republishedDate = entity.RepublishedDate,
                _publishedDate = entity.PublishedDate,
                _checksum = entity.Checksum,
                _fileSize = entity.FileSize,
                _metadataModifiedDate = entity.MetadataModifiedDate,
                _fileName = entity.FileName
            };
        }

        public static List<DocumentAttributesModel>
        FromEntityList(List<Shared.Models.Asset.DocumentAttributes> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (DocumentAttributesModel) entity)
                .ToList();
        }
    }
}
