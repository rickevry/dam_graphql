//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.574Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.GraphQL.Schemas.Asset
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
            Field(o => o.RenditionType, nullable: true);
            Field(o => o.RenditionBlob, nullable: true);
            Field(o => o.Snapshot, nullable: true);
        }
    }
}
