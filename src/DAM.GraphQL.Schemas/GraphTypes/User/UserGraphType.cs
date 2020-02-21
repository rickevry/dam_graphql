//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:16.800Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.GraphQL.Schemas.User
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
            Field(o => o.Role, nullable: true);
        }
    }
}
