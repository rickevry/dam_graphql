//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:17.129Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.GraphQL.Schemas.Asset
{
    public class VersionInputGraphType : InputObjectGraphType<VersionModel>
    {
        public VersionInputGraphType()
        {
            Name = "Asset_VersionInput";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Major, nullable: true);
            Field(o => o.Minor, nullable: true);
            Field(o => o.Current, nullable: true);
            Field(o => o.Snapshot, nullable: true);
        }
    }
}
