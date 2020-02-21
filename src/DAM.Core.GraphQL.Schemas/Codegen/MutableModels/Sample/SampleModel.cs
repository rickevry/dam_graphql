//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:59.029Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Sample
{
    [ModelName("Asset")]
    [QueryName("assets")]
    public class SampleModel : MutableModel
    {
        public static implicit operator SampleModel(
            Shared.Models.Sample.Sample entity
        )

        {
            return FromEntity(entity);
        }

        public static SampleModel FromEntity(Shared.Models.Sample.Sample entity)
        {
            return new SampleModel { Id = entity.Id };
        }

        public static List<SampleModel>
        FromEntityList(List<Shared.Models.Sample.Sample> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (SampleModel) entity).ToList();
        }
    }
}
