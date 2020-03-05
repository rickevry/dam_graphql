//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.Publication;

namespace DAM.Core.GraphQL.Schemas.Publication
{
    [ModelName("Language")]
    [QueryName("Language")]
    public class LanguageModel : MutableModel
    {
        public static implicit operator LanguageModel(
            Shared.Models.Publication.Language entity
        )

        {
            return FromEntity(entity);
        }

        public static LanguageModel
        FromEntity(Shared.Models.Publication.Language entity)
        {
            return new LanguageModel { Id = entity.Id };
        }

        public static List<LanguageModel>
        FromEntityList(List<Shared.Models.Publication.Language> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (LanguageModel) entity).ToList();
        }
    }
}
