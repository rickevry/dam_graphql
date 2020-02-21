//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:58.317Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    [ModelName("DocumentInfo")]
    [QueryName("documentInfo")]
    public class DocumentInfoModel : MutableModel
    {
        private string _internalDescription;

        private string _externalDescription;

        private string _assetType;

        private List<string> _taxonomy;

        private List<string> _languageCode;

        private string _title;

        private Guid _folderId;

        private string _assetRole;

        private DateTime _expiryDate;

        private string _publicationDesignation;

        private List<string> _authors;

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

        public List<string> Authors
        {
            get
            {
                return _authors;
            }
            set
            {
                SetField(ref _authors, value);
            }
        }

        public static implicit operator DocumentInfoModel(
            Shared.Models.Asset.DocumentInfo entity
        )

        {
            return FromEntity(entity);
        }

        public static DocumentInfoModel
        FromEntity(Shared.Models.Asset.DocumentInfo entity)
        {
            return new DocumentInfoModel {
                Id = entity.Id,
                _internalDescription = entity.InternalDescription,
                _externalDescription = entity.ExternalDescription,
                _assetType = entity.AssetType,
                _taxonomy = entity.Taxonomy,
                _languageCode = entity.LanguageCode,
                _title = entity.Title,
                _folderId = entity.FolderId,
                _assetRole = entity.AssetRole,
                _expiryDate = entity.ExpiryDate,
                _publicationDesignation = entity.PublicationDesignation,
                _authors = entity.Authors
            };
        }

        public static List<DocumentInfoModel>
        FromEntityList(List<Shared.Models.Asset.DocumentInfo> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (DocumentInfoModel) entity)
                .ToList();
        }
    }
}
