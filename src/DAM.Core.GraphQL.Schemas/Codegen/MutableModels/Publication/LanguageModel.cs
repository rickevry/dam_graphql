//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.PublicationDomain;

namespace DAM.Core.GraphQL.Schemas.PublicationDomain
{
    [ModelName("Language")]
    [QueryName("Language")]
    public class LanguageModel : MutableModel
    {
        public static implicit operator LanguageModel(
            Shared.Models.PublicationDomain.Language entity
        )

        {
            return FromEntity(entity);
        }

        public static LanguageModel
        FromEntity(Shared.Models.PublicationDomain.Language entity)
        {
            return new LanguageModel { Id = entity.Id };
        }

        public static List<LanguageModel>
        FromEntityList(
            List<Shared.Models.PublicationDomain.Language> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (LanguageModel) entity).ToList();
        }

        public
        static implicit operator Shared.Models.PublicationDomain.Language(
            LanguageModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.PublicationDomain.Language
        ToEntity(LanguageModel model)
        {
            return new Shared.Models.PublicationDomain.Language {
                Id = model.Id
            };
        }

        public static List<Shared.Models.PublicationDomain.Language>
        ToEntityList(List<LanguageModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity =>
                    (Shared.Models.PublicationDomain.Language) entity)
                .ToList();
        }
    }
}
