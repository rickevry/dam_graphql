//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.PublicationDomain;

namespace DAM.Core.GraphQL.Schemas.PublicationDomain
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

        private DateTime _createdDate;

        private Guid _createdBy;

        private DateTime _modifiedDate;

        private Guid _modifiedBy;

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

        /// <summary>
        /// Name in export: publishId
        /// </summary>
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

        public static implicit operator PublicationModel(
            Shared.Models.PublicationDomain.Publication entity
        )

        {
            return FromEntity(entity);
        }

        public static PublicationModel
        FromEntity(Shared.Models.PublicationDomain.Publication entity)
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
                _createdDate = entity.CreatedDate,
                _createdBy = entity.CreatedBy,
                _modifiedDate = entity.ModifiedDate,
                _modifiedBy = entity.ModifiedBy
            };
        }

        public static List<PublicationModel>
        FromEntityList(
            List<Shared.Models.PublicationDomain.Publication> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (PublicationModel) entity)
                .ToList();
        }

        public
        static implicit operator Shared.Models.PublicationDomain.Publication(
            PublicationModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.PublicationDomain.Publication
        ToEntity(PublicationModel model)
        {
            return new Shared.Models.PublicationDomain.Publication {
                Id = model.Id,
                PublicationName = model._publicationName,
                Editions = EditionsModel.ToEntityList(model._editions),
                Assets = AssetsModel.ToEntityList(model._assets),
                PublicationId = model._publicationId,
                AssetType = model._assetType,
                InternalDescription = model._internalDescription,
                ExternalDescription = model._externalDescription,
                PublishingUnit = model._publishingUnit,
                CreatedDate = model._createdDate,
                CreatedBy = model._createdBy,
                ModifiedDate = model._modifiedDate,
                ModifiedBy = model._modifiedBy
            };
        }

        public static List<Shared.Models.PublicationDomain.Publication>
        ToEntityList(List<PublicationModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity =>
                    (Shared.Models.PublicationDomain.Publication) entity)
                .ToList();
        }
    }
}
