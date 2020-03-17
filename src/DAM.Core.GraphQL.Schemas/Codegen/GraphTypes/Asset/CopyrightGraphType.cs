//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.AssetDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.AssetDomain
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
