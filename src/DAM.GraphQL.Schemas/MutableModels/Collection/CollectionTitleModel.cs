//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:16.754Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Collection;

namespace DAM.GraphQL.Schemas.Collection
{
    [ModelName("CollectionTitle")]
    [QueryName("CollectionTitle")]
    public class CollectionTitleModel : MutableModel
    {
        public static implicit operator CollectionTitleModel(
            Services.Models.Collection.CollectionTitle entity
        )

        {
            return FromEntity(entity);
        }

        public static CollectionTitleModel
        FromEntity(Services.Models.Collection.CollectionTitle entity)
        {
            return new CollectionTitleModel { Id = entity.Id };
        }

        public static List<CollectionTitleModel>
        FromEntityList(
            List<Services.Models.Collection.CollectionTitle> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (CollectionTitleModel) entity)
                .ToList();
        }
    }
}
