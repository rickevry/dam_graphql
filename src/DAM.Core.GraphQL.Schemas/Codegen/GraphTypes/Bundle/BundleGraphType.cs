//
//  This file was automatically generated and should not be edited.
//  2020-02-28T09:54:21.210Z
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.Bundle;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Bundle
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
            Field(o => o.CreatedDate, nullable: true);
            Field(o => o.CreatedBy, nullable: true);
            Field(o => o.BundleType, nullable: true);
            Field(o => o.ModifiedDate, nullable: true);
            Field(o => o.ModifiedBy, nullable: true);
            Field(o => o.SortField, nullable: true);
        }
    }
}
