//
//  This file was automatically generated and should not be edited.
//  2020-02-25T11:04:53.791Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Sample
{
    [ModelName("Asset")]
    [QueryName("assets")]
    public class DescriptionModel : MutableModel
    {
        public static implicit operator DescriptionModel(
            Shared.Models.Sample.Description entity
        )

        {
            return FromEntity(entity);
        }

        public static DescriptionModel
        FromEntity(Shared.Models.Sample.Description entity)
        {
            return new DescriptionModel { Id = entity.Id };
        }

        public static List<DescriptionModel>
        FromEntityList(List<Shared.Models.Sample.Description> entityList)
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
