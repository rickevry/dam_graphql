//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.UserDomain;

namespace DAM.Core.GraphQL.Schemas.UserDomain
{
    [ModelName("User")]
    [QueryName("User")]
    public class UserModel : MutableModel
    {
        private string _userName;

        private string _displayName;

        private string _email;

        private string _role;

        private List<Guid> _publishingUnit;

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

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                SetField(ref _email, value);
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

        public List<Guid> PublishingUnit
        {
            get
            {
                return _publishingUnit;
            }
            set
            {
                SetField(ref _publishingUnit, value);
            }
        }

        public static implicit operator UserModel(
            Shared.Models.UserDomain.User entity
        )

        {
            return FromEntity(entity);
        }

        public static UserModel FromEntity(Shared.Models.UserDomain.User entity)
        {
            return new UserModel {
                Id = entity.Id,
                _userName = entity.UserName,
                _displayName = entity.DisplayName,
                _email = entity.Email,
                _role = entity.Role,
                _publishingUnit = entity.PublishingUnit
            };
        }

        public static List<UserModel>
        FromEntityList(List<Shared.Models.UserDomain.User> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (UserModel) entity).ToList();
        }
    }
}
