//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:56.960Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Bundle
{
    public class BundleInputGraphType : InputObjectGraphType<BundleModel>
    {
        public BundleInputGraphType()
        {
            Name = "Bundle_BundleInput";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Id, nullable: true);
            Field(o => o.BundleTitle, nullable: true);
            Field(o => o.BundleDescription, nullable: true);
            Field(o => o.ThumbnailURL, nullable: true);
            Field(o => o.Country, nullable: true);
            Field(o => o.Collections, nullable: true);
            Field(o => o.BundleType, nullable: true);
            Field(o => o.SortField, nullable: true);
        }
    }
}
