//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.403Z
//
using System;
using System.Collections.Generic;
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
            Field(o => o.Current, nullable: true);
            Field(o => o.Snapshot, nullable: true);
        }
    }
}
