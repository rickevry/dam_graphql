//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.071Z
//
using System;
using System.Collections.Generic;
using BlobStorage.DB.Interfaces;

namespace DAM.Services.Models.User
{
    public class User : IEntityId<Guid>
    {
        public Guid Id { get; set; }

        /// <summary>
        /// description missing
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// description missing
        /// </summary>
        public string Role { get; set; }
    }
}
