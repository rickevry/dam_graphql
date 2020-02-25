//
//  This file was automatically generated and should not be edited.
//  2020-02-25T11:04:52.744Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Collection
{
    [ModelName("Collection")]
    [QueryName("collections")]
    public class CollectionModel : MutableModel
    {
        private string _collectionTitle;

        private DateTime _publicationDate;

        private string _collectionDescription;

        private string _collectionType;

        private string _collectionVisibility;

        private List<Guid> _assets;

        private bool _showOnStartPage;

        private Guid _coverAssetId;

        private DateTime _createdDate;

        private Guid _createdBy;

        private bool _isNewCollection;

        private DateTime _modifiedDate;

        private Guid _modifiedBy;

        public string CollectionTitle
        {
            get
            {
                return _collectionTitle;
            }
            set
            {
                SetField(ref _collectionTitle, value);
            }
        }

        public DateTime PublicationDate
        {
            get
            {
                return _publicationDate;
            }
            set
            {
                SetField(ref _publicationDate, value);
            }
        }

        public string CollectionDescription
        {
            get
            {
                return _collectionDescription;
            }
            set
            {
                SetField(ref _collectionDescription, value);
            }
        }

        public string CollectionType
        {
            get
            {
                return _collectionType;
            }
            set
            {
                SetField(ref _collectionType, value);
            }
        }

        public string CollectionVisibility
        {
            get
            {
                return _collectionVisibility;
            }
            set
            {
                SetField(ref _collectionVisibility, value);
            }
        }

        public List<Guid> Assets
        {
            get
            {
                return _assets;
            }
            set
            {
                SetField(ref _assets, value);
            }
        }

        public bool ShowOnStartPage
        {
            get
            {
                return _showOnStartPage;
            }
            set
            {
                SetField(ref _showOnStartPage, value);
            }
        }

        public Guid CoverAssetId
        {
            get
            {
                return _coverAssetId;
            }
            set
            {
                SetField(ref _coverAssetId, value);
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
        public bool isNewCollection
        {
            get
            {
                return _isNewCollection;
            }
            set
            {
                SetField(ref _isNewCollection, value);
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

        public static implicit operator CollectionModel(
            Shared.Models.Collection.Collection entity
        )

        {
            return FromEntity(entity);
        }

        public static CollectionModel
        FromEntity(Shared.Models.Collection.Collection entity)
        {
            return new CollectionModel {
                Id = entity.Id,
                _collectionTitle = entity.CollectionTitle,
                _publicationDate = entity.PublicationDate,
                _collectionDescription = entity.CollectionDescription,
                _collectionType = entity.CollectionType,
                _collectionVisibility = entity.CollectionVisibility,
                _assets = entity.Assets,
                _showOnStartPage = entity.ShowOnStartPage,
                _coverAssetId = entity.CoverAssetId,
                _createdDate = entity.CreatedDate,
                _createdBy = entity.CreatedBy,
                _isNewCollection = entity.isNewCollection,
                _modifiedDate = entity.ModifiedDate,
                _modifiedBy = entity.ModifiedBy
            };
        }

        public static List<CollectionModel>
        FromEntityList(List<Shared.Models.Collection.Collection> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (CollectionModel) entity)
                .ToList();
        }
    }
}
