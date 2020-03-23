//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.AssetDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.AssetDomain
{
    public class ProductInfoMutableGraphType : ObjectGraphType<ProductInfoModel>
    {
        public ProductInfoMutableGraphType()
        {
            Name = "AssetMutable_ProductInfo";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.ProductDesignation,
            true,
            typeof (ListGraphType<ProductDesignationMutableGraphType>))
                .Resolve(context => context.Source.ProductDesignation);
        }
    }
}
