//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:57.079Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.User
{
    public class UserInputGraphType : InputObjectGraphType<UserModel>
    {
        public UserInputGraphType()
        {
            Name = "User_UserInput";

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
