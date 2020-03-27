//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.CollectionDomain;

namespace DAM.Core.GraphQL.Schemas.CollectionDomain
{
    [ModelName("ShowOnStartPage")]
    [QueryName("ShowOnStartPage")]
    public class ShowOnStartPageModel : MutableModel
    {
        public static implicit operator ShowOnStartPageModel(
            Shared.Models.CollectionDomain.ShowOnStartPage entity
        )

        {
            return FromEntity(entity);
        }

        public static ShowOnStartPageModel
        FromEntity(Shared.Models.CollectionDomain.ShowOnStartPage entity)
        {
            return new ShowOnStartPageModel { Id = entity.Id };
        }

        public static List<ShowOnStartPageModel>
        FromEntityList(
            List<Shared.Models.CollectionDomain.ShowOnStartPage> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (ShowOnStartPageModel) entity)
                .ToList();
        }

        public
        static implicit operator Shared.Models.CollectionDomain.ShowOnStartPage(
            ShowOnStartPageModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.CollectionDomain.ShowOnStartPage
        ToEntity(ShowOnStartPageModel model)
        {
            return new Shared.Models.CollectionDomain.ShowOnStartPage {
                Id = model.Id
            };
        }

        public static List<Shared.Models.CollectionDomain.ShowOnStartPage>
        ToEntityList(List<ShowOnStartPageModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity =>
                    (Shared.Models.CollectionDomain.ShowOnStartPage) entity)
                .ToList();
        }
    }
}
