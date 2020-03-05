//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.Asset;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    public class ProductInfoGraphType : ObjectGraphType<ProductInfoModel>
    {
        public ProductInfoGraphType()
        {
            Name = "Asset_ProductInfo";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.ProductDesignation,
            true,
            typeof (ListGraphType<ProductDesignationGraphType>))
                .Resolve(context => context.Source.ProductDesignation);
        }
    }
}
