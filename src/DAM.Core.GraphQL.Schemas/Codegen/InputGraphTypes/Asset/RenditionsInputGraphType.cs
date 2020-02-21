//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:58.970Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    public class
    RenditionsInputGraphType
    : InputObjectGraphType<RenditionsModel>
    {
        public RenditionsInputGraphType()
        {
            Name = "Asset_RenditionsInput";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.RenditionType, nullable: true);
            Field(o => o.Snapshot, nullable: true);
            Field(o => o.FileSize, nullable: true);
        }
    }
}
