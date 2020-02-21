//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:06.931Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Collection
{
    [ModelName("CollectionDescription")]
    [QueryName("CollectionDescription")]
    public class CollectionDescriptionModel : MutableModel
    {
        public static implicit operator CollectionDescriptionModel(
            Services.Models.Collection.CollectionDescription entity
        )

        {
            return FromEntity(entity);
        }

        public static CollectionDescriptionModel
        FromEntity(Services.Models.Collection.CollectionDescription entity)
        {
            return new CollectionDescriptionModel { Id = entity.Id };
        }

        public static List<CollectionDescriptionModel>
        FromEntityList(
            List<Services.Models.Collection.CollectionDescription> entityList
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
