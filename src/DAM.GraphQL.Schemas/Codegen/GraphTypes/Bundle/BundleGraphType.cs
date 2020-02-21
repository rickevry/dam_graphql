//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:06.869Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.GraphQL.Schemas.Bundle
{
    public class BundleGraphType : ObjectGraphType<BundleModel>
    {
        public BundleGraphType()
        {
            Name = "Bundle_Bundle";

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
