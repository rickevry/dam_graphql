//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.866Z
//
using System;
using System.Collections.Generic;
using BlobStorage.DB.Interfaces;

namespace DAM.Services.Models.Asset
{
    public class Rights : IEntityId<Guid>
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Security Class
        /// </summary>
        public string SecurityClass { get; set; }

        /// <summary>
        ///  Rights managed : This field is required by SKF legal and limits the usage and distribution of your asset.
        /// SKF_internal
        /// SKF_open
        /// Rights_managed
        /// Restricted_content_on_skf_com
        /// Publish_enabled_for_skf_com
        /// </summary>
        public bool RightsManaged { get; set; }

        /// <summary>
        /// Tridion restricted (keep or remove?): This field is required by SKF legal and limits the usage and distribution of your asset.
        /// SKF_internal
        /// SKF_open
        /// Rights_managed
        /// Restricted_content_on_skf_com
        /// Publish_enabled_for_skf_com
        /// </summary>
        public bool TridionRestricted { get; set; }

        /// <summary>
        /// Rights managed description : This field is required by SKF legal and limits the usage and distribution of your asset.
        /// SKF_internal
        /// SKF_open
        /// Rights_managed
        /// Restricted_content_on_skf_com
        /// Publish_enabled_for_skf_com
        /// </summary>
        public string RightsManagedDescription { get; set; }
    }
}
