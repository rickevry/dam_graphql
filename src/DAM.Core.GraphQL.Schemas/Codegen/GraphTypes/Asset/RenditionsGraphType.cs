//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.Asset;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    public class RenditionsGraphType : ObjectGraphType<RenditionsModel>
    {
        public RenditionsGraphType()
        {
            Name = "Asset_Renditions";

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
