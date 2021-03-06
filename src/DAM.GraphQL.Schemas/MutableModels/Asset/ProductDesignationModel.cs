//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:17.207Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Asset;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("ProductDesignation")]
    [QueryName("ProductDesignation")]
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
            Services.Models.Asset.ProductDesignation entity
        )

        {
            return FromEntity(entity);
        }

        public static ProductDesignationModel
        FromEntity(Services.Models.Asset.ProductDesignation entity)
        {
            return new ProductDesignationModel {
                Id = entity.Id,
                _designation = entity.Designation,
                _designationType = entity.DesignationType
            };
        }

        public static List<ProductDesignationModel>
        FromEntityList(
            List<Services.Models.Asset.ProductDesignation> entityList
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
