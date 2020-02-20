//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:26.127Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Sample
{
    [ModelName("Category")]
    [QueryName("Category")]
    public class CategoryModel : MutableModel
    {
        public static implicit operator CategoryModel(
            Services.Models.Sample.Category entity
        )

        {
            return FromEntity(entity);
        }

        public static CategoryModel
        FromEntity(Services.Models.Sample.Category entity)
        {
            return new CategoryModel { Id = entity.Id };
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
