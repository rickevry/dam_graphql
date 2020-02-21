//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:59.359Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Sample
{
    [ModelName("Rendition")]
    [QueryName("Rendition")]
    public class RenditionModel : MutableModel
    {
        public static implicit operator RenditionModel(
            Shared.Models.Sample.Rendition entity
        )

        {
            return FromEntity(entity);
        }

        public static RenditionModel
        FromEntity(Shared.Models.Sample.Rendition entity)
        {
            return new RenditionModel { Id = entity.Id };
        }

        public static List<RenditionModel>
        FromEntityList(List<Shared.Models.Sample.Rendition> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (RenditionModel) entity)
                .ToList();
        }
    }
}
