//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.UserDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.UserDomain
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
