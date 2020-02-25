//
//  This file was automatically generated and should not be edited.
//  2020-02-25T11:04:52.666Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Collection
{
    [ModelName("CollectionTitle")]
    [QueryName("CollectionTitle")]
    public class CollectionTitleModel : MutableModel
    {
        public static implicit operator CollectionTitleModel(
            Shared.Models.Collection.CollectionTitle entity
        )

        {
            return FromEntity(entity);
        }

        public static CollectionTitleModel
        FromEntity(Shared.Models.Collection.CollectionTitle entity)
        {
            return new CollectionTitleModel { Id = entity.Id };
        }

        public static List<CollectionTitleModel>
        FromEntityList(
            List<Shared.Models.Collection.CollectionTitle> entityList
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
