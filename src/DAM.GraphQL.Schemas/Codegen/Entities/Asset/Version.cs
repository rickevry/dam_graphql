//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.393Z
//
using System;
using System.Collections.Generic;
using BlobStorage.DB.Interfaces;

namespace DAM.Services.Models.Asset
{
    public class Version : IEntityId<Guid>
    {
        public Guid Id { get; set; }

        /// <summary>
        /// description missing
        /// </summary>
        public int Major { get; set; }

        /// <summary>
        /// description missing
        /// </summary>
        public int Minor { get; set; }

        /// <summary>
        /// description missing
        /// </summary>
        public bool Current { get; set; }

        /// <summary>
        /// description missing
        /// </summary>
        public string Snapshot { get; set; }
    }
}
