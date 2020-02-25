//
//  This file was automatically generated and should not be edited.
//  2020-02-25T11:04:53.666Z
//
using System;
using System.Collections.Generic;
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
