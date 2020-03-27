//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.BundleDomain;

namespace DAM.Core.GraphQL.Schemas.BundleDomain
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

        private DateTime _createdDate;

        private Guid _createdBy;

        private string _bundleType;

        private DateTime _modifiedDate;

        private Guid _modifiedBy;

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

        public DateTime CreatedDate
        {
            get
            {
                return _createdDate;
            }
            set
            {
                SetField(ref _createdDate, value);
            }
        }

        public Guid CreatedBy
        {
            get
            {
                return _createdBy;
            }
            set
            {
                SetField(ref _createdBy, value);
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

        public Guid ModifiedBy
        {
            get
            {
                return _modifiedBy;
            }
            set
            {
                SetField(ref _modifiedBy, value);
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
            Shared.Models.BundleDomain.Bundle entity
        )

        {
            return FromEntity(entity);
        }

        public static BundleModel
        FromEntity(Shared.Models.BundleDomain.Bundle entity)
        {
            return new BundleModel {
                Id = entity.Id,
                _bundleTitle = entity.BundleTitle,
                _bundleDescription = entity.BundleDescription,
                _thumbnailURL = entity.ThumbnailURL,
                _country = entity.Country,
                _collections = entity.Collections,
                _createdDate = entity.CreatedDate,
                _createdBy = entity.CreatedBy,
                _bundleType = entity.BundleType,
                _modifiedDate = entity.ModifiedDate,
                _modifiedBy = entity.ModifiedBy,
                _sortField = entity.SortField
            };
        }

        public static List<BundleModel>
        FromEntityList(List<Shared.Models.BundleDomain.Bundle> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (BundleModel) entity).ToList();
        }

        public static implicit operator Shared.Models.BundleDomain.Bundle(
            BundleModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.BundleDomain.Bundle
        ToEntity(BundleModel model)
        {
            return new Shared.Models.BundleDomain.Bundle {
                Id = model.Id,
                BundleTitle = model._bundleTitle,
                BundleDescription = model._bundleDescription,
                ThumbnailURL = model._thumbnailURL,
                Country = model._country,
                Collections = model._collections,
                CreatedDate = model._createdDate,
                CreatedBy = model._createdBy,
                BundleType = model._bundleType,
                ModifiedDate = model._modifiedDate,
                ModifiedBy = model._modifiedBy,
                SortField = model._sortField
            };
        }

        public static List<Shared.Models.BundleDomain.Bundle>
        ToEntityList(List<BundleModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity => (Shared.Models.BundleDomain.Bundle) entity)
                .ToList();
        }
    }
}
