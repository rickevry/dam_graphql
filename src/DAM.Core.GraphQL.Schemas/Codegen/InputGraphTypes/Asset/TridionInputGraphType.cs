//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.AssetDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.AssetDomain
{
    public class TridionInputGraphType : InputObjectGraphType<TridionModel>
    {
        public TridionInputGraphType()
        {
            Name = "Asset_TridionInput";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Sites, nullable: true);
        }
    }
}
