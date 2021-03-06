//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:16.925Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Publication;

namespace DAM.GraphQL.Schemas.Publication
{
    [ModelName("Categories")]
    [QueryName("Categories")]
    public class CategoriesModel : MutableModel
    {
        public static implicit operator CategoriesModel(
            Services.Models.Publication.Categories entity
        )

        {
            return FromEntity(entity);
        }

        public static CategoriesModel
        FromEntity(Services.Models.Publication.Categories entity)
        {
            return new CategoriesModel { Id = entity.Id };
        }

        public static List<CategoriesModel>
        FromEntityList(List<Services.Models.Publication.Categories> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (CategoriesModel) entity)
                .ToList();
        }
    }
}
