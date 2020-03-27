//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.AssetDomain;

namespace DAM.Core.GraphQL.Schemas.AssetDomain
{
    [ModelName("DocumentInfo")]
    [QueryName("documentInfo")]
    public class DocumentInfoModel : MutableModel
    {
        private string _internalDescription;

        private string _externalDescription;

        private string _assetType;

        private List<string> _taxonomy;

        private List<LanguagesModel> _languages;

        private string _title;

        private Guid _folderId;

        private string _assetRole;

        private string _publicationDesignation;

        private string _securityClass;

        private bool _tridionRestricted;

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

        /// <summary>
        /// AssetType|(external)
        /// </summary>
        public string AssetType
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
        /// Industry (multi, external)
        /// </summary>
        public List<string> Taxonomy
        {
            get
            {
                return _taxonomy;
            }
            set
            {
                SetField(ref _taxonomy, value);
            }
        }

        /// <summary>
        /// Language: Set the language of your asset. The language tag will serve as information for users informing that this asset is in another language then English.
        /// The tag will also serve as a language filter allowing users to select asset in a specific language. When publishing asset to NG it will be available via Media Library on Knowledge Center. The language will decide which other country site, other then the international site (Group), the asset should appear on.
        /// Eg content set as Russian will make asset appear on the Russian site and the International site (Group).
        /// Note: All Media Library asset will be available through free text search independent of language
        /// Multilingual: If your asset is multilingual (eg a manual) you can add several language tagsImages: Language tag for images not displaying any text on the image should be set to language independent
        /// </summary>
        public List<LanguagesModel> Languages
        {
            get
            {
                return _languages;
            }
            set
            {
                SetField(ref _languages, value);
            }
        }

        /// <summary>
        /// Title: Mandatory
        /// Is the name that would appear online. This field will be searchable in all our channels and in external search such as Google.
        /// The naming convention to ensure proper search match should be very specific to the Asset & match the filename, No abbreviations or language codes etc
        /// Designation-Brand-Product-Name (ie. 6205 SKF Deep Groove Ball Bearing)

        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                SetField(ref _title, value);
            }
        }

        public Guid FolderId
        {
            get
            {
                return _folderId;
            }
            set
            {
                SetField(ref _folderId, value);
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

        /// <summary>
        /// Security Class
        /// </summary>
        public string SecurityClass
        {
            get
            {
                return _securityClass;
            }
            set
            {
                SetField(ref _securityClass, value);
            }
        }

        /// <summary>
        /// Tridion restricted (keep or remove?): This field is required by SKF legal and limits the usage and distribution of your asset.
        /// SKF_internal
        /// SKF_open
        /// Rights_managed
        /// Restricted_content_on_skf_com
        /// Publish_enabled_for_skf_com
        /// </summary>
        public bool TridionRestricted
        {
            get
            {
                return _tridionRestricted;
            }
            set
            {
                SetField(ref _tridionRestricted, value);
            }
        }

        public static implicit operator DocumentInfoModel(
            Shared.Models.AssetDomain.DocumentInfo entity
        )

        {
            return FromEntity(entity);
        }

        public static DocumentInfoModel
        FromEntity(Shared.Models.AssetDomain.DocumentInfo entity)
        {
            return new DocumentInfoModel {
                Id = entity.Id,
                _internalDescription = entity.InternalDescription,
                _externalDescription = entity.ExternalDescription,
                _assetType = entity.AssetType,
                _taxonomy = entity.Taxonomy,
                _languages = LanguagesModel.FromEntityList(entity.Languages),
                _title = entity.Title,
                _folderId = entity.FolderId,
                _assetRole = entity.AssetRole,
                _publicationDesignation = entity.PublicationDesignation,
                _securityClass = entity.SecurityClass,
                _tridionRestricted = entity.TridionRestricted
            };
        }

        public static List<DocumentInfoModel>
        FromEntityList(List<Shared.Models.AssetDomain.DocumentInfo> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (DocumentInfoModel) entity)
                .ToList();
        }

        public static implicit operator Shared.Models.AssetDomain.DocumentInfo(
            DocumentInfoModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.AssetDomain.DocumentInfo
        ToEntity(DocumentInfoModel model)
        {
            return new Shared.Models.AssetDomain.DocumentInfo {
                Id = model.Id,
                InternalDescription = model._internalDescription,
                ExternalDescription = model._externalDescription,
                AssetType = model._assetType,
                Taxonomy = model._taxonomy,
                Languages = LanguagesModel.ToEntityList(model._languages),
                Title = model._title,
                FolderId = model._folderId,
                AssetRole = model._assetRole,
                PublicationDesignation = model._publicationDesignation,
                SecurityClass = model._securityClass,
                TridionRestricted = model._tridionRestricted
            };
        }

        public static List<Shared.Models.AssetDomain.DocumentInfo>
        ToEntityList(List<DocumentInfoModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity =>
                    (Shared.Models.AssetDomain.DocumentInfo) entity)
                .ToList();
        }
    }
}
