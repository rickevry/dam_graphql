//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:06.863Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Bundle
{
    [ModelName("Bundle")]
    [QueryName("bundles")]
    public class BundleModel : MutableModel
    {
        private string _bundleTitle;

        private string _bundleDescription;

        private string _thumbnailURL;

        private List<string> _country;

        private List<Guid> _collections;

        private string _bundleType;

        private string _sortField;

        public string BundleTitle
        {
            get
            {
                return _bundleTitle;
            }
            set
            {
                SetField(ref _bundleTitle, value);
            }
        }

        public string BundleDescription
        {
            get
            {
                return _bundleDescription;
            }
            set
            {
                SetField(ref _bundleDescription, value);
            }
        }

        /// <summary>
        /// hello
        /// world
        /// </summary>
        public string ThumbnailURL
        {
            get
            {
                return _thumbnailURL;
            }
            set
            {
                SetField(ref _thumbnailURL, value);
            }
        }

        public List<string> Country
        {
            get
            {
                return _country;
            }
            set
            {
                SetField(ref _country, value);
            }
        }

        public List<Guid> Collections
        {
            get
            {
                return _collections;
            }
            set
            {
                SetField(ref _collections, value);
            }
        }

        /// <summary>
        /// description missing
        /// </summary>
        public string BundleType
        {
            get
            {
                return _bundleType;
            }
            set
            {
                SetField(ref _bundleType, value);
            }
        }

        /// <summary>
        /// description missing
        /// </summary>
        public string SortField
        {
            get
            {
                return _sortField;
            }
            set
            {
                SetField(ref _sortField, value);
            }
        }

        public static implicit operator BundleModel(
            Services.Models.Bundle.Bundle entity
        )

        {
            return FromEntity(entity);
        }

        public static BundleModel
        FromEntity(Services.Models.Bundle.Bundle entity)
        {
            return new BundleModel {
                Id = entity.Id,
                _bundleTitle = entity.BundleTitle,
                _bundleDescription = entity.BundleDescription,
                _thumbnailURL = entity.ThumbnailURL,
                _country = entity.Country,
                _collections = entity.Collections,
                _bundleType = entity.BundleType,
                _sortField = entity.SortField
            };
        }

        public static List<BundleModel>
        FromEntityList(List<Services.Models.Bundle.Bundle> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (BundleModel) entity).ToList();
        }
    }
}
