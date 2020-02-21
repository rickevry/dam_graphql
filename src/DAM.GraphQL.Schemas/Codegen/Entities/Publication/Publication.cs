//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.110Z
//
using System;
using System.Collections.Generic;
using BlobStorage.DB.Interfaces;

namespace DAM.Services.Models.Publication
{
    public class Publication : IEntityId<Guid>
    {
        public Guid Id { get; set; }

        public string PublicationName { get; set; }

        public List<Editions> Editions { get; set; }

        public List<Assets> Assets { get; set; }

        public string PublicationId { get; set; }

        public AssetType AssetType { get; set; }

        public string InternalDescription { get; set; }

        public string ExternalDescription { get; set; }

        public Guid PublishingUnit { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ModifyDate { get; set; }
    }
}
