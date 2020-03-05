//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.Sample;

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
