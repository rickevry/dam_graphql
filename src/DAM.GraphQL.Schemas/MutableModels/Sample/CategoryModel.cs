//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:17.332Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Sample;

namespace DAM.GraphQL.Schemas.Sample
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
            Services.Models.Sample.Category entity
        )

        {
            return FromEntity(entity);
        }

        public static CategoryModel
        FromEntity(Services.Models.Sample.Category entity)
        {
            return new CategoryModel {
                Id = entity.Id,
                _categoryType = entity.CategoryType
            };
        }

        public static List<CategoryModel>
        FromEntityList(List<Services.Models.Sample.Category> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (CategoryModel) entity).ToList();
        }
    }
}
