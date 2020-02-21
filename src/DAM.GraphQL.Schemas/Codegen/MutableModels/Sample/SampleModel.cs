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
    [ModelName("Asset")]
    [QueryName("assets")]
    public class SampleModel : MutableModel
    {
        public static implicit operator SampleModel(
            Services.Models.Sample.Sample entity
        )

        {
            return FromEntity(entity);
        }

        public static SampleModel
        FromEntity(Services.Models.Sample.Sample entity)
        {
            return new SampleModel { Id = entity.Id };
        }

        public static List<SampleModel>
        FromEntityList(List<Services.Models.Sample.Sample> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (SampleModel) entity).ToList();
        }
    }
}
