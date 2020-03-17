//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.CollectionDomain;

namespace DAM.Core.GraphQL.Schemas.CollectionDomain
{
    [ModelName("CollectionTitle")]
    [QueryName("CollectionTitle")]
    public class CollectionTitleModel : MutableModel
    {
        public static implicit operator CollectionTitleModel(
            Shared.Models.CollectionDomain.CollectionTitle entity
        )

        {
            return FromEntity(entity);
        }

        public static CollectionTitleModel
        FromEntity(Shared.Models.CollectionDomain.CollectionTitle entity)
        {
            return new CollectionTitleModel { Id = entity.Id };
        }

        public static List<CollectionTitleModel>
        FromEntityList(
            List<Shared.Models.CollectionDomain.CollectionTitle> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (CollectionTitleModel) entity)
                .ToList();
        }
    }
}
