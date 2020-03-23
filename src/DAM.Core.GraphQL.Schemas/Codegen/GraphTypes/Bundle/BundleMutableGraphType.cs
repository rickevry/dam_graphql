//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.BundleDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.BundleDomain
{
    public class BundleMutableGraphType : ObjectGraphType<BundleModel>
    {
        public BundleMutableGraphType()
        {
            Name = "BundleMutable_Bundle";

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
            Field(o => o.CreatedDate, nullable: true);
            Field(o => o.CreatedBy, nullable: true);
            Field(o => o.BundleType, nullable: true);
            Field(o => o.ModifiedDate, nullable: true);
            Field(o => o.ModifiedBy, nullable: true);
            Field(o => o.SortField, nullable: true);
        }
    }
}
