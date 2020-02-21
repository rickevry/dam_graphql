//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.078Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.User
{
    [ModelName("User")]
    [QueryName("User")]
    public class UserModel : MutableModel
    {
        private string _username;

        private string _role;

        /// <summary>
        /// description missing
        /// </summary>
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                SetField(ref _username, value);
            }
        }

        /// <summary>
        /// description missing
        /// </summary>
        public string Role
        {
            get
            {
                return _role;
            }
            set
            {
                SetField(ref _role, value);
            }
        }

        public static implicit operator UserModel(
            Services.Models.User.User entity
        )

        {
            return FromEntity(entity);
        }

        public static UserModel FromEntity(Services.Models.User.User entity)
        {
            return new UserModel {
                Id = entity.Id,
                _username = entity.Username,
                _role = entity.Role
            };
        }

        public static List<UserModel>
        FromEntityList(List<Services.Models.User.User> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (UserModel) entity).ToList();
        }
    }
}
