//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.SampleDomain;

namespace DAM.Core.GraphQL.Schemas.SampleDomain
{
    [ModelName("Language")]
    [QueryName("Language")]
    public class LanguageModel : MutableModel
    {
        public static implicit operator LanguageModel(
            Shared.Models.SampleDomain.Language entity
        )

        {
            return FromEntity(entity);
        }

        public static LanguageModel
        FromEntity(Shared.Models.SampleDomain.Language entity)
        {
            return new LanguageModel { Id = entity.Id };
        }

        public static List<LanguageModel>
        FromEntityList(List<Shared.Models.SampleDomain.Language> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (LanguageModel) entity).ToList();
        }

        public static implicit operator Shared.Models.SampleDomain.Language(
            LanguageModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.SampleDomain.Language
        ToEntity(LanguageModel model)
        {
            return new Shared.Models.SampleDomain.Language { Id = model.Id };
        }

        public static List<Shared.Models.SampleDomain.Language>
        ToEntityList(List<LanguageModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity => (Shared.Models.SampleDomain.Language) entity)
                .ToList();
        }
    }
}
