//
//  This file was automatically generated and should not be edited.
//  2020-02-12T14:09:32.102Z
//
using System;
using System.Collections.Generic;
using DAM.Core.DataModels.Asset;
using GraphQL.Types;

namespace DAM.GraphQL.Schemas.Asset
{
    public class VersionGraphType : ObjectGraphType<VersionModel>
    {
        public VersionGraphType()
        {
            Name = "Asset_Version";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Major, nullable: true);
            Field(o => o.Minor, nullable: true);
        }
    }
}
