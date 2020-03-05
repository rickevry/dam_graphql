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
    [ModelName("Language")]
    [QueryName("Language")]
    public class LanguageModel : MutableModel
    {
        public static implicit operator LanguageModel(
            Shared.Models.Sample.Language entity
        )

        {
            return FromEntity(entity);
        }

        public static LanguageModel
        FromEntity(Shared.Models.Sample.Language entity)
        {
            return new LanguageModel { Id = entity.Id };
        }

        public static List<LanguageModel>
        FromEntityList(List<Shared.Models.Sample.Language> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (LanguageModel) entity).ToList();
        }
    }
}
