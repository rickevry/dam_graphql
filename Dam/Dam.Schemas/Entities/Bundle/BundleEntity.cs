//
//  This file was automatically generated and should not be edited.
//  2020-01-31T20:54:44.729Z
//
using System;
using System.Collections.Generic;
using Dam.Schemas.Attributes;

namespace Dam.Schemas.Entities.Bundle
{
    [QueryName("Bundle")]
    public class BundleEntity
    {
        /// <summary>
        /// description missing
        /// </summary>
        public string BundleId { get; set; }

        /// <summary>
        /// Version of the bundle
        /// </summary>
        public VersionEntity Version { get; set; }

        public string BundleTitle { get; set; }

        public string BundleDescription { get; set; }

        public List<string> LanguagesInAssets { get; set; }

        public List<AttachmentEntity> Attachment { get; set; }

        /// <summary>
        /// hello
        /// world
        /// </summary>
        public string Icon { get; set; }

        public string Country { get; set; }

        public string Collections { get; set; }
    }
}
