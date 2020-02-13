//
//  This file was automatically generated and should not be edited.
//  2020-02-12T14:09:32.135Z
//
using System;
using System.Collections.Generic;
using DAM.Core.DataModels.Asset;
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
