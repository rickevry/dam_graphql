//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.172Z
//
using System;
using System.Collections.Generic;
using BlobStorage.DB.Interfaces;

namespace DAM.Services.Models.Publication
{
    public class Languages : IEntityId<Guid>
    {
        public Guid Id { get; set; }

        public Language Language { get; set; }

        public List<Assets> Assets { get; set; }
    }
}