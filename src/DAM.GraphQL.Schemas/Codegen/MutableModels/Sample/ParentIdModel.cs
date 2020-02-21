//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.682Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Sample
{
    [ModelName("ParentId")]
    [QueryName("ParentId")]
    public class ParentIdModel : MutableModel
    {
        public static implicit operator ParentIdModel(
            Services.Models.Sample.ParentId entity
        )

        {
            return FromEntity(entity);
        }

        public static ParentIdModel
        FromEntity(Services.Models.Sample.ParentId entity)
        {
            return new ParentIdModel { Id = entity.Id };
        }

        public static List<ParentIdModel>
        FromEntityList(List<Services.Models.Sample.ParentId> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (ParentIdModel) entity).ToList();
        }
    }
}
