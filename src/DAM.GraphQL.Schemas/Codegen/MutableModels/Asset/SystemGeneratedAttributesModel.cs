//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.580Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("SystemGeneratedAttributes")]
    [QueryName("SystemGeneratedAttributes")]
    public class SystemGeneratedAttributesModel : MutableModel
    {
        private long _size;

        private string _checksum;

        private DateTime _modifiedDate;

        private DateTime _republishedDate;

        private List<RenditionsModel> _renditions;

        private DateTime _publishedDate;

        private bool _isCheckedOut;

        private string _checkedOutBy;

        public long Size
        {
            get
            {
                return _size;
            }
            set
            {
                SetField(ref _size, value);
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

        public DateTime ModifiedDate
        {
            get
            {
                return _modifiedDate;
            }
            set
            {
                SetField(ref _modifiedDate, value);
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
        /// Multi
        /// </summary>
        public List<RenditionsModel> Renditions
        {
            get
            {
                return _renditions;
            }
            set
            {
                SetField(ref _renditions, value);
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

        /// <summary>
        /// description missing
        /// </summary>
        public string CheckedOutBy
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

        public static implicit operator SystemGeneratedAttributesModel(
            Services.Models.Asset.SystemGeneratedAttributes entity
        )

        {
            return FromEntity(entity);
        }

        public static SystemGeneratedAttributesModel
        FromEntity(Services.Models.Asset.SystemGeneratedAttributes entity)
        {
            return new SystemGeneratedAttributesModel {
                Id = entity.Id,
                _size = entity.Size,
                _checksum = entity.Checksum,
                _modifiedDate = entity.ModifiedDate,
                _republishedDate = entity.RepublishedDate,
                _renditions = RenditionsModel.FromEntityList(entity.Renditions),
                _publishedDate = entity.PublishedDate,
                _isCheckedOut = entity.IsCheckedOut,
                _checkedOutBy = entity.CheckedOutBy
            };
        }

        public static List<SystemGeneratedAttributesModel>
        FromEntityList(
            List<Services.Models.Asset.SystemGeneratedAttributes> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (SystemGeneratedAttributesModel) entity)
                .ToList();
        }
    }
}
