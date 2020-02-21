//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:57.763Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Publication
{
    [ModelName("InternalDescription")]
    [QueryName("InternalDescription")]
    public class InternalDescriptionModel : MutableModel
    {
        public static implicit operator InternalDescriptionModel(
            Shared.Models.Publication.InternalDescription entity
        )

        {
            return FromEntity(entity);
        }

        public static InternalDescriptionModel
        FromEntity(Shared.Models.Publication.InternalDescription entity)
        {
            return new InternalDescriptionModel { Id = entity.Id };
        }

        public static List<InternalDescriptionModel>
        FromEntityList(
            List<Shared.Models.Publication.InternalDescription> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (InternalDescriptionModel) entity)
                .ToList();
        }
    }
}
