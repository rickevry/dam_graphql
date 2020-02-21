//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.636Z
//
using System;
using System.Collections.Generic;
using BlobStorage.DB.Interfaces;

namespace DAM.Services.Models.Sample
{
    public class Category : IEntityId<Guid>
    {
        public Guid Id { get; set; }

        public Guid CategoryType { get; set; }
    }
}
