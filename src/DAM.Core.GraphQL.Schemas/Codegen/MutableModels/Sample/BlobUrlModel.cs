//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:59.423Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Sample
{
    [ModelName("BlobUrl")]
    [QueryName("BlobUrl")]
    public class BlobUrlModel : MutableModel
    {
        public static implicit operator BlobUrlModel(
            Shared.Models.Sample.BlobUrl entity
        )

        {
            return FromEntity(entity);
        }

        public static BlobUrlModel
        FromEntity(Shared.Models.Sample.BlobUrl entity)
        {
            return new BlobUrlModel { Id = entity.Id };
        }

        public static List<BlobUrlModel>
        FromEntityList(List<Shared.Models.Sample.BlobUrl> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (BlobUrlModel) entity).ToList();
        }
    }
}
