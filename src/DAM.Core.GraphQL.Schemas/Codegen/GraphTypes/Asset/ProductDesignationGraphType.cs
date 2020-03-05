//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.Asset;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    public class
    ProductDesignationGraphType
    : ObjectGraphType<ProductDesignationModel>
    {
        public ProductDesignationGraphType()
        {
            Name = "Asset_ProductDesignation";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Designation, nullable: true);
            Field(o => o.DesignationType, nullable: true);
        }
    }
}
