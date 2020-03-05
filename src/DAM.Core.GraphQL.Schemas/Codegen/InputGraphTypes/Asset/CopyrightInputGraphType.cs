//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.Asset;
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
