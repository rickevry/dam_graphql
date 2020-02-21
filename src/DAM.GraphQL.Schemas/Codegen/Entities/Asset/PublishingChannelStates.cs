//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.427Z
//
using System;
using System.Collections.Generic;
using BlobStorage.DB.Interfaces;

namespace DAM.Services.Models.Asset
{
    public class PublishingChannelStates : IEntityId<Guid>
    {
        public Guid Id { get; set; }

        public string Channel { get; set; }

        public string State { get; set; }
    }
}
