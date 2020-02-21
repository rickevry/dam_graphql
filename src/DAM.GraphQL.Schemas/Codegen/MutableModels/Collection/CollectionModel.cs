//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:06.961Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Collection
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

        private bool _isNewCollection;

        private DateTime _creationDate;

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

        public DateTime CreationDate
        {
            get
            {
                return _creationDate;
            }
            set
            {
                SetField(ref _creationDate, value);
            }
        }

        public static implicit operator CollectionModel(
            Services.Models.Collection.Collection entity
        )

        {
            return FromEntity(entity);
        }

        public static CollectionModel
        FromEntity(Services.Models.Collection.Collection entity)
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
                _isNewCollection = entity.isNewCollection,
                _creationDate = entity.CreationDate
            };
        }

        public static List<CollectionModel>
        FromEntityList(List<Services.Models.Collection.Collection> entityList)
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
