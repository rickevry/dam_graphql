//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:06.797Z
//
using System;
using System.Collections.Generic;
using BlobStorage.DB.Interfaces;

namespace DAM.Services.Models.Bundle
{
    public class Bundle : IEntityId<Guid>
    {
        public Guid Id { get; set; }

        public string BundleTitle { get; set; }

        public string BundleDescription { get; set; }

        /// <summary>
        /// hello
        /// world
        /// </summary>
        public string ThumbnailURL { get; set; }

        public List<string> Country { get; set; }

        public List<Guid> Collections { get; set; }

        /// <summary>
        /// description missing
        /// </summary>
        public string BundleType { get; set; }

        /// <summary>
        /// description missing
        /// </summary>
        public string SortField { get; set; }
    }
}
