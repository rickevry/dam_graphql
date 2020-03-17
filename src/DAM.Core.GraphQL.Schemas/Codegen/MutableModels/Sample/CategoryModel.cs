//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.SampleDomain;

namespace DAM.Core.GraphQL.Schemas.SampleDomain
{
    [ModelName("Category")]
    [QueryName("Category")]
    public class CategoryModel : MutableModel
    {
        private Guid _categoryType;

        public Guid CategoryType
        {
            get
            {
                return _categoryType;
            }
            set
            {
                SetField(ref _categoryType, value);
            }
        }

        public static implicit operator CategoryModel(
            Shared.Models.SampleDomain.Category entity
        )

        {
            return FromEntity(entity);
        }

        public static CategoryModel
        FromEntity(Shared.Models.SampleDomain.Category entity)
        {
            return new CategoryModel {
                Id = entity.Id,
                _categoryType = entity.CategoryType
            };
        }

        public static List<CategoryModel>
        FromEntityList(List<Shared.Models.SampleDomain.Category> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (CategoryModel) entity).ToList();
        }
    }
}
