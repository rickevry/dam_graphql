//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.AssetDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.AssetDomain
{
    public class TridionMutableGraphType : ObjectGraphType<TridionModel>
    {
        public TridionMutableGraphType()
        {
            Name = "AssetMutable_Tridion";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Sites, nullable: true);
        }
    }
}
