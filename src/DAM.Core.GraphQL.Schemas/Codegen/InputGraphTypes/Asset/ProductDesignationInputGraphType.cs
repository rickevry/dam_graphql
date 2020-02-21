//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:58.570Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    public class
    ProductDesignationInputGraphType
    : InputObjectGraphType<ProductDesignationModel>
    {
        public ProductDesignationInputGraphType()
        {
            Name = "Asset_ProductDesignationInput";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Designation, nullable: true);
            Field(o => o.DesignationType, nullable: true);
        }
    }
}
