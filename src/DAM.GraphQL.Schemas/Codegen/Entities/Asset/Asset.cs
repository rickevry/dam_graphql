//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.367Z
//
using System;
using System.Collections.Generic;
using BlobStorage.DB.Interfaces;

namespace DAM.Services.Models.Asset
{
    public class Asset : IEntityId<Guid>
    {
        public Guid Id { get; set; }

        public string AssetId { get; set; }

        public string PublishId { get; set; }

        public string PublishingUnit { get; set; }

        public string PublicationID { get; set; }

        /// <summary>
        /// AssetType|(external)
        /// </summary>
        public AssetType AssetType { get; set; }

        /// <summary>
        /// Title: Mandatory
        /// Is the name that would appear online. This field will be searchable in all our channels and in external search such as Google.
        /// The naming convention to ensure proper search match should be very specific to the Asset & match the filename, No abbreviations or language codes etc
        /// Designation-Brand-Product-Name (ie. 6205 SKF Deep Groove Ball Bearing)

        /// </summary>
        public string AssetTitle { get; set; }

        /// <summary>
        /// Asset source : Explains the soruce from which your asset was fist produced
        /// SKF_internally_produced
        /// Customer_produced
        /// SKF_contracted_supplier
        /// Shutterstock_using_SKF_Corporate_License
        /// </summary>
        public string AssetSource { get; set; }

        /// <summary>
        /// Language: Set the language of your asset. The language tag will serve as information for users informing that this asset is in another language then English.
        /// The tag will also serve as a language filter allowing users to select asset in a specific language. When publishing asset to NG it will be available via Media Library on Knowledge Center. The language will decide which other country site, other then the international site (Group), the asset should appear on.
        /// Eg content set as Russian will make asset appear on the Russian site and the International site (Group).
        /// Note: All Media Library asset will be available through free text search independent of language
        /// Multilingual: If your asset is multilingual (eg a manual) you can add several language tagsImages: Language tag for images not displaying any text on the image should be set to language independent
        /// </summary>
        public List<string> LanguageCode { get; set; }

        /// <summary>
        /// File name: Is the name you give the file on your computer. This field will be searchable in all our channels and in external search such as Google.
        /// In Media Finder, photos/illustrations/Rich media/Zip the file name will appear as the title.
        /// The naming convention to ensure proper search match should be very specific to the Asset & match the set title, No abbreviations or language codes etc
        /// Designation-Brand-ProductName-industry (ie. 6205 SKF Deep Groove Ball Bearing used in food processing plant)
        /// </summary>
        public string AssetFileName { get; set; }

        /// <summary>
        /// a
        /// </summary>
        public SystemGeneratedAttributes SystemGeneratedAttributes { get; set; }

        public string CopyrightOwner { get; set; }

        /// <summary>
        /// Industry (multi, external)
        /// </summary>
        public List<string> Industry { get; set; }

        /// <summary>
        /// Internal description (SKF intranet): Mandatory field
        /// In English The description should briefly describe the content, inherently including the main key-words and abbreviations.
        /// The Internal discription field text is indexed and ranked high in search results in Media Master, Media Finder and via Spider.
        /// The text is visible for users to read and should be descriptive.
        /// Field should be filled out in English for all assets
        /// </summary>
        public string InternalDescription { get; set; }

        public string CopyrightDescription { get; set; }

        /// <summary>
        /// Products (multi, external)
        /// </summary>
        public List<string> Products { get; set; }

        /// <summary>
        /// External description (Tridion): Describes the IMPORTANT FEATURES of the product/service in the document for external users, not that is its a "5 page brochure". No useless information.
        /// This will be searchable on skf.com and in external search engines such as Google and needs to match the search query of the user, local or English
        /// Important that it is one the correct language, same language as the contents of the document. Chinese document should have a Chinese external description, not English.
        /// tip: Copy paste from the local pdf if you do not speak the language.
        /// </summary>
        public string ExternalDescription { get; set; }

        public DateTime CopyrightExpiryDate { get; set; }

        /// <summary>
        /// Services (multi, external)
        /// </summary>
        public List<string> Services { get; set; }

        /// <summary>
        /// File name: Is the name you give the file on your computer. This field will be searchable in all our channels and in external search such as Google.
        /// In Media Finder, photos/illustrations/Rich media/Zip the file name will appear as the title.
        /// The naming convention to ensure proper search match should be very specific to the Asset & match the set title, No abbreviations or language codes etc
        /// Designation-Brand-ProductName-industry (ie. 6205 SKF Deep Groove Ball Bearing used in food processing plant)
        /// </summary>
        public string OriginalFileName { get; set; }

        /// <summary>
        /// Version of the bundle
        /// </summary>
        public Version Version { get; set; }

        /// <summary>
        /// (renamed)
        /// </summary>
        public bool PublishEnabled { get; set; }

        /// <summary>
        /// Corporate|(multi, external)
        /// </summary>
        public List<Corporate> Corporate { get; set; }

        /// <summary>
        /// WebPim,Tridion
        /// </summary>
        public List<PublishingChannelStates> PublishingChannelStates
        { get; set;
        }

        /// <summary>
        /// Expiry date: How long will your asset be valid?
        /// By default system sets it to 2 years, but it can be modified. When your asset is about to reach its expiry date you as content manager will receive a notificaton e-mail 2 weeks prior to expiry. A red triangle will also be visible in the bottom of your asset. If you wish to extend the life of your asset you will need to modify the metadata field and re-publish your asset for the change to synch through.
        /// If Expiry date is met the asset/structure will be unpublished automatically by system
        /// </summary>
        public DateTime ExpiryDate { get; set; }

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
        public string AssetRole { get; set; }

        public string PublicationDesignation { get; set; }

        public List<CustomerChannel> CustomerChannel { get; set; }

        /// <summary>
        /// (x,y,z)
        /// </summary>
        public List<AssetSites> AssetSites { get; set; }

        /// <summary>
        /// Designation / Product code : Set more detail for products. Mostly used for product images

        /// </summary>
        public List<ProductDesignation> ProductDesignation { get; set; }

        /// <summary>
        /// Working, accepted, archived, deleted, deleted
        /// </summary>
        public string State { get; set; }

        public Rights Rights { get; set; }
    }
}
