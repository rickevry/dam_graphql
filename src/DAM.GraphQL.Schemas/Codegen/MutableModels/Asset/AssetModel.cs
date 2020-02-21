//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.965Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("Asset")]
    [QueryName("assets")]
    public class AssetModel : MutableModel
    {
        private string _assetId;

        private string _publishId;

        private string _publishingUnit;

        private string _publicationID;

        private AssetTypeModel _assetType;

        private string _assetTitle;

        private string _assetSource;

        private List<string> _languageCode;

        private string _assetFileName;

        private SystemGeneratedAttributesModel _systemGeneratedAttributes;

        private string _copyrightOwner;

        private List<string> _industry;

        private string _internalDescription;

        private string _copyrightDescription;

        private List<string> _products;

        private string _externalDescription;

        private DateTime _copyrightExpiryDate;

        private List<string> _services;

        private string _originalFileName;

        private VersionModel _version;

        private bool _publishEnabled;

        private List<CorporateModel> _corporate;

        private List<PublishingChannelStatesModel> _publishingChannelStates;

        private DateTime _expiryDate;

        private string _assetRole;

        private string _publicationDesignation;

        private List<CustomerChannelModel> _customerChannel;

        private List<AssetSitesModel> _assetSites;

        private List<ProductDesignationModel> _productDesignation;

        private string _state;

        private RightsModel _rights;

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

        public string PublishingUnit
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

        public string PublicationID
        {
            get
            {
                return _publicationID;
            }
            set
            {
                SetField(ref _publicationID, value);
            }
        }

        /// <summary>
        /// AssetType|(external)
        /// </summary>
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

        /// <summary>
        /// Title: Mandatory
        /// Is the name that would appear online. This field will be searchable in all our channels and in external search such as Google.
        /// The naming convention to ensure proper search match should be very specific to the Asset & match the filename, No abbreviations or language codes etc
        /// Designation-Brand-Product-Name (ie. 6205 SKF Deep Groove Ball Bearing)

        /// </summary>
        public string AssetTitle
        {
            get
            {
                return _assetTitle;
            }
            set
            {
                SetField(ref _assetTitle, value);
            }
        }

        /// <summary>
        /// Asset source : Explains the soruce from which your asset was fist produced
        /// SKF_internally_produced
        /// Customer_produced
        /// SKF_contracted_supplier
        /// Shutterstock_using_SKF_Corporate_License
        /// </summary>
        public string AssetSource
        {
            get
            {
                return _assetSource;
            }
            set
            {
                SetField(ref _assetSource, value);
            }
        }

        /// <summary>
        /// Language: Set the language of your asset. The language tag will serve as information for users informing that this asset is in another language then English.
        /// The tag will also serve as a language filter allowing users to select asset in a specific language. When publishing asset to NG it will be available via Media Library on Knowledge Center. The language will decide which other country site, other then the international site (Group), the asset should appear on.
        /// Eg content set as Russian will make asset appear on the Russian site and the International site (Group).
        /// Note: All Media Library asset will be available through free text search independent of language
        /// Multilingual: If your asset is multilingual (eg a manual) you can add several language tagsImages: Language tag for images not displaying any text on the image should be set to language independent
        /// </summary>
        public List<string> LanguageCode
        {
            get
            {
                return _languageCode;
            }
            set
            {
                SetField(ref _languageCode, value);
            }
        }

        /// <summary>
        /// File name: Is the name you give the file on your computer. This field will be searchable in all our channels and in external search such as Google.
        /// In Media Finder, photos/illustrations/Rich media/Zip the file name will appear as the title.
        /// The naming convention to ensure proper search match should be very specific to the Asset & match the set title, No abbreviations or language codes etc
        /// Designation-Brand-ProductName-industry (ie. 6205 SKF Deep Groove Ball Bearing used in food processing plant)
        /// </summary>
        public string AssetFileName
        {
            get
            {
                return _assetFileName;
            }
            set
            {
                SetField(ref _assetFileName, value);
            }
        }

        /// <summary>
        /// a
        /// </summary>
        public SystemGeneratedAttributesModel SystemGeneratedAttributes
        {
            get
            {
                return _systemGeneratedAttributes;
            }
            set
            {
                SetField(ref _systemGeneratedAttributes, value);
            }
        }

        public string CopyrightOwner
        {
            get
            {
                return _copyrightOwner;
            }
            set
            {
                SetField(ref _copyrightOwner, value);
            }
        }

        /// <summary>
        /// Industry (multi, external)
        /// </summary>
        public List<string> Industry
        {
            get
            {
                return _industry;
            }
            set
            {
                SetField(ref _industry, value);
            }
        }

        /// <summary>
        /// Internal description (SKF intranet): Mandatory field
        /// In English The description should briefly describe the content, inherently including the main key-words and abbreviations.
        /// The Internal discription field text is indexed and ranked high in search results in Media Master, Media Finder and via Spider.
        /// The text is visible for users to read and should be descriptive.
        /// Field should be filled out in English for all assets
        /// </summary>
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

        public string CopyrightDescription
        {
            get
            {
                return _copyrightDescription;
            }
            set
            {
                SetField(ref _copyrightDescription, value);
            }
        }

        /// <summary>
        /// Products (multi, external)
        /// </summary>
        public List<string> Products
        {
            get
            {
                return _products;
            }
            set
            {
                SetField(ref _products, value);
            }
        }

        /// <summary>
        /// External description (Tridion): Describes the IMPORTANT FEATURES of the product/service in the document for external users, not that is its a "5 page brochure". No useless information.
        /// This will be searchable on skf.com and in external search engines such as Google and needs to match the search query of the user, local or English
        /// Important that it is one the correct language, same language as the contents of the document. Chinese document should have a Chinese external description, not English.
        /// tip: Copy paste from the local pdf if you do not speak the language.
        /// </summary>
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

        public DateTime CopyrightExpiryDate
        {
            get
            {
                return _copyrightExpiryDate;
            }
            set
            {
                SetField(ref _copyrightExpiryDate, value);
            }
        }

        /// <summary>
        /// Services (multi, external)
        /// </summary>
        public List<string> Services
        {
            get
            {
                return _services;
            }
            set
            {
                SetField(ref _services, value);
            }
        }

        /// <summary>
        /// File name: Is the name you give the file on your computer. This field will be searchable in all our channels and in external search such as Google.
        /// In Media Finder, photos/illustrations/Rich media/Zip the file name will appear as the title.
        /// The naming convention to ensure proper search match should be very specific to the Asset & match the set title, No abbreviations or language codes etc
        /// Designation-Brand-ProductName-industry (ie. 6205 SKF Deep Groove Ball Bearing used in food processing plant)
        /// </summary>
        public string OriginalFileName
        {
            get
            {
                return _originalFileName;
            }
            set
            {
                SetField(ref _originalFileName, value);
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
        /// (renamed)
        /// </summary>
        public bool PublishEnabled
        {
            get
            {
                return _publishEnabled;
            }
            set
            {
                SetField(ref _publishEnabled, value);
            }
        }

        /// <summary>
        /// Corporate|(multi, external)
        /// </summary>
        public List<CorporateModel> Corporate
        {
            get
            {
                return _corporate;
            }
            set
            {
                SetField(ref _corporate, value);
            }
        }

        /// <summary>
        /// WebPim,Tridion
        /// </summary>
        public List<PublishingChannelStatesModel> PublishingChannelStates
        {
            get
            {
                return _publishingChannelStates;
            }
            set
            {
                SetField(ref _publishingChannelStates, value);
            }
        }

        /// <summary>
        /// Expiry date: How long will your asset be valid?
        /// By default system sets it to 2 years, but it can be modified. When your asset is about to reach its expiry date you as content manager will receive a notificaton e-mail 2 weeks prior to expiry. A red triangle will also be visible in the bottom of your asset. If you wish to extend the life of your asset you will need to modify the metadata field and re-publish your asset for the change to synch through.
        /// If Expiry date is met the asset/structure will be unpublished automatically by system
        /// </summary>
        public DateTime ExpiryDate
        {
            get
            {
                return _expiryDate;
            }
            set
            {
                SetField(ref _expiryDate, value);
            }
        }

        /// <summary>
        /// Asset role: Determines the carachtaristics of your asset and usage areas and limitations
        /// Component
        /// Final_format
        /// Original_image
        /// Layout_file
        /// Review_file
        /// Input_or_Source_file
        /// Manuscript_file
        /// </summary>
        public string AssetRole
        {
            get
            {
                return _assetRole;
            }
            set
            {
                SetField(ref _assetRole, value);
            }
        }

        public string PublicationDesignation
        {
            get
            {
                return _publicationDesignation;
            }
            set
            {
                SetField(ref _publicationDesignation, value);
            }
        }

        public List<CustomerChannelModel> CustomerChannel
        {
            get
            {
                return _customerChannel;
            }
            set
            {
                SetField(ref _customerChannel, value);
            }
        }

        /// <summary>
        /// (x,y,z)
        /// </summary>
        public List<AssetSitesModel> AssetSites
        {
            get
            {
                return _assetSites;
            }
            set
            {
                SetField(ref _assetSites, value);
            }
        }

        /// <summary>
        /// Designation / Product code : Set more detail for products. Mostly used for product images

        /// </summary>
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
        /// Working, accepted, archived, deleted, deleted
        /// </summary>
        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                SetField(ref _state, value);
            }
        }

        public RightsModel Rights
        {
            get
            {
                return _rights;
            }
            set
            {
                SetField(ref _rights, value);
            }
        }

        public static implicit operator AssetModel(
            Services.Models.Asset.Asset entity
        )

        {
            return FromEntity(entity);
        }

        public static AssetModel FromEntity(Services.Models.Asset.Asset entity)
        {
            return new AssetModel {
                Id = entity.Id,
                _assetId = entity.AssetId,
                _publishId = entity.PublishId,
                _publishingUnit = entity.PublishingUnit,
                _publicationID = entity.PublicationID,
                _assetType = entity.AssetType,
                _assetTitle = entity.AssetTitle,
                _assetSource = entity.AssetSource,
                _languageCode = entity.LanguageCode,
                _assetFileName = entity.AssetFileName,
                _systemGeneratedAttributes = entity.SystemGeneratedAttributes,
                _copyrightOwner = entity.CopyrightOwner,
                _industry = entity.Industry,
                _internalDescription = entity.InternalDescription,
                _copyrightDescription = entity.CopyrightDescription,
                _products = entity.Products,
                _externalDescription = entity.ExternalDescription,
                _copyrightExpiryDate = entity.CopyrightExpiryDate,
                _services = entity.Services,
                _originalFileName = entity.OriginalFileName,
                _version = entity.Version,
                _publishEnabled = entity.PublishEnabled,
                _corporate = CorporateModel.FromEntityList(entity.Corporate),
                _publishingChannelStates =
                    PublishingChannelStatesModel
                        .FromEntityList(entity.PublishingChannelStates),
                _expiryDate = entity.ExpiryDate,
                _assetRole = entity.AssetRole,
                _publicationDesignation = entity.PublicationDesignation,
                _customerChannel =
                    CustomerChannelModel.FromEntityList(entity.CustomerChannel),
                _assetSites = AssetSitesModel.FromEntityList(entity.AssetSites),
                _productDesignation =
                    ProductDesignationModel
                        .FromEntityList(entity.ProductDesignation),
                _state = entity.State,
                _rights = entity.Rights
            };
        }

        public static List<AssetModel>
        FromEntityList(List<Services.Models.Asset.Asset> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (AssetModel) entity).ToList();
        }
    }
}
