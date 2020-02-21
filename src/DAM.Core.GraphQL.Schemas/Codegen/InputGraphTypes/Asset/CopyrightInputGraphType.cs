//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:58.149Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    public class CopyrightInputGraphType : InputObjectGraphType<CopyrightModel>
    {
        public CopyrightInputGraphType()
        {
            Name = "Asset_CopyrightInput";

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
