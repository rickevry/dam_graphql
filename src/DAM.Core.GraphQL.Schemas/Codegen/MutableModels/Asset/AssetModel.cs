//
//  This file was automatically generated and should not be edited.
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

        private CopyrightModel _copyright;

        private string _assetId;

        private string _publicationId;

        private DocumentAttributesModel _documentAttributes;

        private DocumentInfoModel _documentInfo;

        private Guid _publishingUnitId;

        private ReleaseFormModel _releaseForm;

        private ProductInfoModel _productInfo;

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

        public CopyrightModel Copyright
        {
            get
            {
                return _copyright;
            }
            set
            {
                SetField(ref _copyright, value);
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

        /// <summary>
        /// All files within the ZIP file need to comply to SKF Group Policy of the Use of SKF information, for details please visit SKF intranet and SKF Identity guidelines, for details please visit SKF Visual identity standards.
        ///

        /// If ZIP file contains photo(s) these need to be approved for commercial purposes.
        /// You are not permitted to have photo(s) in the ZIP file that requires release form(s) unless precise details of full name of subjects are stated in the ZIP file description. Release form(s) must be stored along with the photo(s) in the ZIP file.
        ///

        /// If unsure, please contact the Content Manager of the workspace.
        /// </summary>
        public ReleaseFormModel ReleaseForm
        {
            get
            {
                return _releaseForm;
            }
            set
            {
                SetField(ref _releaseForm, value);
            }
        }

        public ProductInfoModel ProductInfo
        {
            get
            {
                return _productInfo;
            }
            set
            {
                SetField(ref _productInfo, value);
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
                _copyright = entity.Copyright,
                _assetId = entity.AssetId,
                _publicationId = entity.PublicationId,
                _documentAttributes = entity.DocumentAttributes,
                _documentInfo = entity.DocumentInfo,
                _publishingUnitId = entity.PublishingUnitId,
                _releaseForm = entity.ReleaseForm,
                _productInfo = entity.ProductInfo,
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
