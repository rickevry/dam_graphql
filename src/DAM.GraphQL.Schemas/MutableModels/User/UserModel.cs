//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:16.800Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.User;

namespace DAM.GraphQL.Schemas.User
{
    [ModelName("User")]
    [QueryName("User")]
    public class UserModel : MutableModel
    {
        private string _userName;

        private string _displayName;

        private string _role;

        /// <summary>
        /// description missing
        /// </summary>
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                SetField(ref _userName, value);
            }
        }

        /// <summary>
        /// description missing
        /// </summary>
        public string DisplayName
        {
            get
            {
                return _displayName;
            }
            set
            {
                SetField(ref _displayName, value);
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
                _userName = entity.UserName,
                _displayName = entity.DisplayName,
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
