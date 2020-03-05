//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.Asset;
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
            Field(o => o.Snapshot, nullable: true);
            Field(o => o.FileSize, nullable: true);
            Field(o => o.RenditionType, nullable: true);
        }
    }
}
