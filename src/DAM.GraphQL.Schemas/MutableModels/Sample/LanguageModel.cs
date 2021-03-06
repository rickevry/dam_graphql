//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:17.332Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Sample;

namespace DAM.GraphQL.Schemas.Sample
{
    [ModelName("Language")]
    [QueryName("Language")]
    public class LanguageModel : MutableModel
    {
        public static implicit operator LanguageModel(
            Services.Models.Sample.Language entity
        )

        {
            return FromEntity(entity);
        }

        public static LanguageModel
        FromEntity(Services.Models.Sample.Language entity)
        {
            return new LanguageModel { Id = entity.Id };
        }

        public static List<LanguageModel>
        FromEntityList(List<Services.Models.Sample.Language> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (LanguageModel) entity).ToList();
        }
    }
}
