//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:57.792Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Publication
{
    [ModelName("Categories")]
    [QueryName("Categories")]
    public class CategoriesModel : MutableModel
    {
        public static implicit operator CategoriesModel(
            Shared.Models.Publication.Categories entity
        )

        {
            return FromEntity(entity);
        }

        public static CategoriesModel
        FromEntity(Shared.Models.Publication.Categories entity)
        {
            return new CategoriesModel { Id = entity.Id };
        }

        public static List<CategoriesModel>
        FromEntityList(List<Shared.Models.Publication.Categories> entityList)
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