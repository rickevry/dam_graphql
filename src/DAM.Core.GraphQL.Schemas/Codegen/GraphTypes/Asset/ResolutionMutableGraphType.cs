//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.AssetDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.AssetDomain
{
    public class ResolutionMutableGraphType : ObjectGraphType<ResolutionModel>
    {
        public ResolutionMutableGraphType()
        {
            Name = "AssetMutable_Resolution";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.X, nullable: true);
            Field(o => o.Y, nullable: true);
        }
    }
}
