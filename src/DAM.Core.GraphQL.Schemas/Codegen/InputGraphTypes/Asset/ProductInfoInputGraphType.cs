//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:58.574Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    public class
    ProductInfoInputGraphType
    : InputObjectGraphType<ProductInfoModel>
    {
        public ProductInfoInputGraphType()
        {
            Name = "Asset_ProductInfoInput";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.ProductDesignation,
            true,
            typeof (ListGraphType<ProductDesignationInputGraphType>))
                .Resolve(context => context.Source.ProductDesignation);
        }
    }
}
