//
//  This file was automatically generated and should not be edited.
//  2020-02-12T14:09:31.885Z
//
using System;
using System.Collections.Generic;
using DAM.Core.DataModels.Bundle;
using GraphQL.Types;

namespace DAM.GraphQL.Schemas.Bundle
{
    public class VersionGraphType : ObjectGraphType<VersionModel>
    {
        public VersionGraphType()
        {
            Name = "Bundle_Version";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Major, nullable: true);
            Field(o => o.Minor, nullable: true);
        }
    }
}
