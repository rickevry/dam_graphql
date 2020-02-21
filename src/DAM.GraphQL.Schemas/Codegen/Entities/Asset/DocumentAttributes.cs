//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.291Z
//
using System;
using System.Collections.Generic;
using BlobStorage.DB.Interfaces;

namespace DAM.Services.Models.Asset
{
    public class DocumentAttributes : IEntityId<Guid>
    {
        public Guid Id { get; set; }

        public List<string> DocumentContent { get; set; }

        public long Size { get; set; }

        public string Checksum { get; set; }
    }
}
