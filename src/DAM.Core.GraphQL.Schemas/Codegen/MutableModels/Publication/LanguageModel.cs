//
//  This file was automatically generated and should not be edited.
//  2020-02-25T11:04:52.963Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

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
