//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:06.942Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Collection
{
    [ModelName("ShowOnStartPage")]
    [QueryName("ShowOnStartPage")]
    public class ShowOnStartPageModel : MutableModel
    {
        public static implicit operator ShowOnStartPageModel(
            Services.Models.Collection.ShowOnStartPage entity
        )

        {
            return FromEntity(entity);
        }

        public static ShowOnStartPageModel
        FromEntity(Services.Models.Collection.ShowOnStartPage entity)
        {
            return new ShowOnStartPageModel { Id = entity.Id };
        }

        public static List<ShowOnStartPageModel>
        FromEntityList(
            List<Services.Models.Collection.ShowOnStartPage> entityList
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
