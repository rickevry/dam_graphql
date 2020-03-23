//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.AssetDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.AssetDomain
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
            Field(o => o.FileSize, nullable: true);
            Field(o => o.Snapshot, nullable: true);
            Field(o => o.RenditionType, nullable: true);
            Field(o => o.DownloadUrl, nullable: true);
            Field(o => o.MimeType, nullable: true);
        }
    }
}
