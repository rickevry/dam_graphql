//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.157Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Publication
{
    [ModelName("Publication")]
    [QueryName("publications")]
    public class PublicationModel : MutableModel
    {
        private string _publicationName;

        private List<EditionsModel> _editions;

        private List<AssetsModel> _assets;

        private string _publicationId;

        private AssetTypeModel _assetType;

        private string _internalDescription;

        private string _externalDescription;

        private Guid _publishingUnit;

        private DateTime _creationDate;

        private DateTime _modifyDate;

        public string PublicationName
        {
            get
            {
                return _publicationName;
            }
            set
            {
                SetField(ref _publicationName, value);
            }
        }

        public List<EditionsModel> Editions
        {
            get
            {
                return _editions;
            }
            set
            {
                SetField(ref _editions, value);
            }
        }

        public List<AssetsModel> Assets
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

        public string PublicationId
        {
            get
            {
                return _publicationId;
            }
            set
            {
                SetField(ref _publicationId, value);
            }
        }

        public AssetTypeModel AssetType
        {
            get
            {
                return _assetType;
            }
            set
            {
                SetField(ref _assetType, value);
            }
        }

        public string InternalDescription
        {
            get
            {
                return _internalDescription;
            }
            set
            {
                SetField(ref _internalDescription, value);
            }
        }

        public string ExternalDescription
        {
            get
            {
                return _externalDescription;
            }
            set
            {
                SetField(ref _externalDescription, value);
            }
        }

        public Guid PublishingUnit
        {
            get
            {
                return _publishingUnit;
            }
            set
            {
                SetField(ref _publishingUnit, value);
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

        public DateTime ModifyDate
        {
            get
            {
                return _modifyDate;
            }
            set
            {
                SetField(ref _modifyDate, value);
            }
        }

        public static implicit operator PublicationModel(
            Services.Models.Publication.Publication entity
        )

        {
            return FromEntity(entity);
        }

        public static PublicationModel
        FromEntity(Services.Models.Publication.Publication entity)
        {
            return new PublicationModel {
                Id = entity.Id,
                _publicationName = entity.PublicationName,
                _editions = EditionsModel.FromEntityList(entity.Editions),
                _assets = AssetsModel.FromEntityList(entity.Assets),
                _publicationId = entity.PublicationId,
                _assetType = entity.AssetType,
                _internalDescription = entity.InternalDescription,
                _externalDescription = entity.ExternalDescription,
                _publishingUnit = entity.PublishingUnit,
                _creationDate = entity.CreationDate,
                _modifyDate = entity.ModifyDate
            };
        }

        public static List<PublicationModel>
        FromEntityList(List<Services.Models.Publication.Publication> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (PublicationModel) entity)
                .ToList();
        }
    }
}
