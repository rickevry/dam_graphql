//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.138Z
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
