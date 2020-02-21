//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.714Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Sample
{
    [ModelName("Rendition")]
    [QueryName("Rendition")]
    public class RenditionModel : MutableModel
    {
        public static implicit operator RenditionModel(
            Services.Models.Sample.Rendition entity
        )

        {
            return FromEntity(entity);
        }

        public static RenditionModel
        FromEntity(Services.Models.Sample.Rendition entity)
        {
            return new RenditionModel { Id = entity.Id };
        }

        public static List<RenditionModel>
        FromEntityList(List<Services.Models.Sample.Rendition> entityList)
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
