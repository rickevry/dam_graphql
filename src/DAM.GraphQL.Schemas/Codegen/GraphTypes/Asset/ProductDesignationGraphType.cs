//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.813Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.GraphQL.Schemas.Asset
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
