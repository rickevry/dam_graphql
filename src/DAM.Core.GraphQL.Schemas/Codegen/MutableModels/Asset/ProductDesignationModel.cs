//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.AssetDomain;

namespace DAM.Core.GraphQL.Schemas.AssetDomain
{
    [ModelName("ProductDesignation")]
    [QueryName("productDesignation")]
    public class ProductDesignationModel : MutableModel
    {
        private string _designation;

        private string _designationType;

        public string Designation
        {
            get
            {
                return _designation;
            }
            set
            {
                SetField(ref _designation, value);
            }
        }

        public string DesignationType
        {
            get
            {
                return _designationType;
            }
            set
            {
                SetField(ref _designationType, value);
            }
        }

        public static implicit operator ProductDesignationModel(
            Shared.Models.AssetDomain.ProductDesignation entity
        )

        {
            return FromEntity(entity);
        }

        public static ProductDesignationModel
        FromEntity(Shared.Models.AssetDomain.ProductDesignation entity)
        {
            return new ProductDesignationModel {
                Id = entity.Id,
                _designation = entity.Designation,
                _designationType = entity.DesignationType
            };
        }

        public static List<ProductDesignationModel>
        FromEntityList(
            List<Shared.Models.AssetDomain.ProductDesignation> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (ProductDesignationModel) entity)
                .ToList();
        }
    }
}
