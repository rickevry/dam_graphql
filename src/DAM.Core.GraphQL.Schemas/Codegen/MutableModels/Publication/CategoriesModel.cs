//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.PublicationDomain;

namespace DAM.Core.GraphQL.Schemas.PublicationDomain
{
    [ModelName("Categories")]
    [QueryName("Categories")]
    public class CategoriesModel : MutableModel
    {
        public static implicit operator CategoriesModel(
            Shared.Models.PublicationDomain.Categories entity
        )

        {
            return FromEntity(entity);
        }

        public static CategoriesModel
        FromEntity(Shared.Models.PublicationDomain.Categories entity)
        {
            return new CategoriesModel { Id = entity.Id };
        }

        public static List<CategoriesModel>
        FromEntityList(
            List<Shared.Models.PublicationDomain.Categories> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (CategoriesModel) entity)
                .ToList();
        }

        public
        static implicit operator Shared.Models.PublicationDomain.Categories(
            CategoriesModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.PublicationDomain.Categories
        ToEntity(CategoriesModel model)
        {
            return new Shared.Models.PublicationDomain.Categories {
                Id = model.Id
            };
        }

        public static List<Shared.Models.PublicationDomain.Categories>
        ToEntityList(List<CategoriesModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity =>
                    (Shared.Models.PublicationDomain.Categories) entity)
                .ToList();
        }
    }
}
