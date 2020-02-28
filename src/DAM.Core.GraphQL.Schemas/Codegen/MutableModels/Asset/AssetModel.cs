//
//  This file was automatically generated and should not be edited.
//  2020-02-28T09:54:23.241Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.Asset;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    [ModelName("Asset")]
    [QueryName("assets")]
    public class AssetModel : MutableModel
    {
        private DocumentStateModel _documentState;

        private string _assetId;

        private string _publicationId;

        private DocumentAttributesModel _documentAttributes;

        private string _publishId;

        private DocumentInfoModel _documentInfo;

        private Guid _publishingUnitId;

        private List<ProductDesignationModel> _productDesignation;

        private VersionModel _version;

        private List<RenditionsModel> _renditions;

        private DateTime _createdDate;

        private DateTime _modifiedDate;

        private Guid _createdBy;

        private Guid _modifiedBy;

        public DocumentStateModel DocumentState
        {
            get
            {
                return _documentState;
            }
            set
            {
                SetField(ref _documentState, value);
            }
        }

        public string AssetId
        {
            get
            {
                return _assetId;
            }
            set
            {
                SetField(ref _assetId, value);
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

        public DocumentAttributesModel DocumentAttributes
        {
            get
            {
                return _documentAttributes;
            }
            set
            {
                SetField(ref _documentAttributes, value);
            }
        }

        public string PublishId
        {
            get
            {
                return _publishId;
            }
            set
            {
                SetField(ref _publishId, value);
            }
        }

        public DocumentInfoModel DocumentInfo
        {
            get
            {
                return _documentInfo;
            }
            set
            {
                SetField(ref _documentInfo, value);
            }
        }

        public Guid PublishingUnitId
        {
            get
            {
                return _publishingUnitId;
            }
            set
            {
                SetField(ref _publishingUnitId, value);
            }
        }

        public List<ProductDesignationModel> ProductDesignation
        {
            get
            {
                return _productDesignation;
            }
            set
            {
                SetField(ref _productDesignation, value);
            }
        }

        /// <summary>
        /// Version of the bundle
        /// </summary>
        public VersionModel Version
        {
            get
            {
                return _version;
            }
            set
            {
                SetField(ref _version, value);
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

        public static implicit operator AssetModel(
            Shared.Models.Asset.Asset entity
        )

        {
            return FromEntity(entity);
        }

        public static AssetModel FromEntity(Shared.Models.Asset.Asset entity)
        {
            return new AssetModel {
                Id = entity.Id,
                _documentState = entity.DocumentState,
                _assetId = entity.AssetId,
                _publicationId = entity.PublicationId,
                _documentAttributes = entity.DocumentAttributes,
                _publishId = entity.PublishId,
                _documentInfo = entity.DocumentInfo,
                _publishingUnitId = entity.PublishingUnitId,
                _productDesignation =
                    ProductDesignationModel
                        .FromEntityList(entity.ProductDesignation),
                _version = entity.Version,
                _renditions = RenditionsModel.FromEntityList(entity.Renditions),
                _createdDate = entity.CreatedDate,
                _modifiedDate = entity.ModifiedDate,
                _createdBy = entity.CreatedBy,
                _modifiedBy = entity.ModifiedBy
            };
        }

        public static List<AssetModel>
        FromEntityList(List<Shared.Models.Asset.Asset> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (AssetModel) entity).ToList();
        }
    }
}
