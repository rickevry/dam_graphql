//
//  This file was automatically generated and should not be edited.
//  2020-02-28T09:54:22.749Z
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.Asset;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    public class CopyrightGraphType : ObjectGraphType<CopyrightModel>
    {
        public CopyrightGraphType()
        {
            Name = "Asset_Copyright";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.AssetSource, nullable: true);
            Field(o => o.CopyrightOwner, nullable: true);
            Field(o => o.CopyrightDescription, nullable: true);
            Field(o => o.CopyrightExpiryDate, nullable: true);
        }
    }
}
