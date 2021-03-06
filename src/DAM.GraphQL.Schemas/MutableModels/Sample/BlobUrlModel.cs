//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:17.410Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Sample;

namespace DAM.GraphQL.Schemas.Sample
{
    [ModelName("BlobUrl")]
    [QueryName("BlobUrl")]
    public class BlobUrlModel : MutableModel
    {
        public static implicit operator BlobUrlModel(
            Services.Models.Sample.BlobUrl entity
        )

        {
            return FromEntity(entity);
        }

        public static BlobUrlModel
        FromEntity(Services.Models.Sample.BlobUrl entity)
        {
            return new BlobUrlModel { Id = entity.Id };
        }

        public static List<BlobUrlModel>
        FromEntityList(List<Services.Models.Sample.BlobUrl> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (BlobUrlModel) entity).ToList();
        }
    }
}
