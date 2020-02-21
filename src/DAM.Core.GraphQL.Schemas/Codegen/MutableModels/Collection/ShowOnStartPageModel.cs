//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:57.243Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Collection
{
    [ModelName("ShowOnStartPage")]
    [QueryName("ShowOnStartPage")]
    public class ShowOnStartPageModel : MutableModel
    {
        public static implicit operator ShowOnStartPageModel(
            Shared.Models.Collection.ShowOnStartPage entity
        )

        {
            return FromEntity(entity);
        }

        public static ShowOnStartPageModel
        FromEntity(Shared.Models.Collection.ShowOnStartPage entity)
        {
            return new ShowOnStartPageModel { Id = entity.Id };
        }

        public static List<ShowOnStartPageModel>
        FromEntityList(
            List<Shared.Models.Collection.ShowOnStartPage> entityList
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
    }
}
