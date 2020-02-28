//
//  This file was automatically generated and should not be edited.
//  2020-02-28T09:54:21.275Z
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.User;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.User
{
    public class UserGraphType : ObjectGraphType<UserModel>
    {
        public UserGraphType()
        {
            Name = "User_User";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Id, nullable: true);
            Field(o => o.UserName, nullable: true);
            Field(o => o.DisplayName, nullable: true);
            Field(o => o.Email, nullable: true);
            Field(o => o.Role, nullable: true);
            Field(o => o.PublishingUnit, nullable: true);
        }
    }
}
