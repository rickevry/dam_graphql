//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.541Z
//
using System;
using System.Collections.Generic;
using BlobStorage.DB.Interfaces;

namespace DAM.Services.Models.Asset
{
    public class SystemGeneratedAttributes : IEntityId<Guid>
    {
        public Guid Id { get; set; }

        public long Size { get; set; }

        public string Checksum { get; set; }

        public DateTime ModifiedDate { get; set; }

        public DateTime RepublishedDate { get; set; }

        /// <summary>
        /// Multi
        /// </summary>
        public List<Renditions> Renditions { get; set; }

        /// <summary>
        /// Publish date: Will be the date you publish your asset. It can also be pre-set to a future date if needed. Once published, the asset will not be visible untill the set future date is met.
        /// </summary>
        public DateTime PublishedDate { get; set; }

        /// <summary>
        /// description missing
        /// </summary>
        public bool IsCheckedOut { get; set; }

        /// <summary>
        /// description missing
        /// </summary>
        public string CheckedOutBy { get; set; }
    }
}
