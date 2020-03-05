//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.Asset;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    [ModelName("ProductInfo")]
    [QueryName("productInfo")]
    public class ProductInfoModel : MutableModel
    {
        private List<ProductDesignationModel> _productDesignation;

        /// <summary>
        /// Designation / Product code : Set more detail for products. Mostly used for product images

        /// </summary>
        public List<ProductDesignationModel> ProductDesignation
        {
            get
            {
                return _productDesignation;
            }
            set
            {
                SetField(ref _productDesignation, value);
            }
        }

        public static implicit operator ProductInfoModel(
            Shared.Models.Asset.ProductInfo entity
        )

        {
            return FromEntity(entity);
        }

        public static ProductInfoModel
        FromEntity(Shared.Models.Asset.ProductInfo entity)
        {
            return new ProductInfoModel {
                Id = entity.Id,
                _productDesignation =
                    ProductDesignationModel
                        .FromEntityList(entity.ProductDesignation)
            };
        }

        public static List<ProductInfoModel>
        FromEntityList(List<Shared.Models.Asset.ProductInfo> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (ProductInfoModel) entity)
                .ToList();
        }
    }
}
