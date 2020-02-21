//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:24.984Z
//
using System;
using System.Collections.Generic;
using BlobStorage.DB.Interfaces;

namespace DAM.Services.Models.Collection
{
    public class Collection : IEntityId<Guid>
    {
        public Guid Id { get; set; }

        public string CollectionTitle { get; set; }

        public DateTime PublicationDate { get; set; }

        public string CollectionDescription { get; set; }

        public string CollectionType { get; set; }

        public string CollectionVisibility { get; set; }

        public List<Guid> Assets { get; set; }

        public bool ShowOnStartPage { get; set; }

        public Guid CoverAssetId { get; set; }

        /// <summary>
        /// description missing
        /// </summary>
        public bool isNewCollection { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
