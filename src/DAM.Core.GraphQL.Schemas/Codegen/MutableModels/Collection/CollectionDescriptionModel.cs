//
//  This file was automatically generated and should not be edited.
//  2020-02-25T11:04:52.682Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Collection
{
    [ModelName("CollectionDescription")]
    [QueryName("CollectionDescription")]
    public class CollectionDescriptionModel : MutableModel
    {
        public static implicit operator CollectionDescriptionModel(
            Shared.Models.Collection.CollectionDescription entity
        )

        {
            return FromEntity(entity);
        }

        public static CollectionDescriptionModel
        FromEntity(Shared.Models.Collection.CollectionDescription entity)
        {
            return new CollectionDescriptionModel { Id = entity.Id };
        }

        public static List<CollectionDescriptionModel>
        FromEntityList(
            List<Shared.Models.Collection.CollectionDescription> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (CollectionDescriptionModel) entity)
                .ToList();
        }
    }
}
