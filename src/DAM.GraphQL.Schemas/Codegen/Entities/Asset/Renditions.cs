//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.565Z
//
using System;
using System.Collections.Generic;
using BlobStorage.DB.Interfaces;

namespace DAM.Services.Models.Asset
{
    public class Renditions : IEntityId<Guid>
    {
        public Guid Id { get; set; }

        public string RenditionType { get; set; }

        public string RenditionBlob { get; set; }

        /// <summary>
        /// description missing
        /// </summary>
        public string Snapshot { get; set; }
    }
}
