//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.031Z
//
using System;
using System.Collections.Generic;
using BlobStorage.DB.Interfaces;

namespace DAM.Services.Models.Publication
{
    public class Editions : IEntityId<Guid>
    {
        public Guid Id { get; set; }

        public Guid Name { get; set; }

        public List<Languages> Languages { get; set; }
    }
}
