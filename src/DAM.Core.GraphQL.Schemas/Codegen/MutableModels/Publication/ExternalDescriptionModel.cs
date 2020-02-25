//
//  This file was automatically generated and should not be edited.
//  2020-02-25T11:04:53.088Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Publication
{
    [ModelName("ExternalDescription")]
    [QueryName("ExternalDescription")]
    public class ExternalDescriptionModel : MutableModel
    {
        public static implicit operator ExternalDescriptionModel(
            Shared.Models.Publication.ExternalDescription entity
        )

        {
            return FromEntity(entity);
        }

        public static ExternalDescriptionModel
        FromEntity(Shared.Models.Publication.ExternalDescription entity)
        {
            return new ExternalDescriptionModel { Id = entity.Id };
        }

        public static List<ExternalDescriptionModel>
        FromEntityList(
            List<Shared.Models.Publication.ExternalDescription> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (ExternalDescriptionModel) entity)
                .ToList();
        }
    }
}
