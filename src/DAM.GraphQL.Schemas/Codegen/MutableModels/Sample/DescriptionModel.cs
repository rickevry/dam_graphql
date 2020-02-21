//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.621Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Sample
{
    [ModelName("Asset")]
    [QueryName("assets")]
    public class DescriptionModel : MutableModel
    {
        public static implicit operator DescriptionModel(
            Services.Models.Sample.Description entity
        )

        {
            return FromEntity(entity);
        }

        public static DescriptionModel
        FromEntity(Services.Models.Sample.Description entity)
        {
            return new DescriptionModel { Id = entity.Id };
        }

        public static List<DescriptionModel>
        FromEntityList(List<Services.Models.Sample.Description> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (DescriptionModel) entity)
                .ToList();
        }
    }
}
