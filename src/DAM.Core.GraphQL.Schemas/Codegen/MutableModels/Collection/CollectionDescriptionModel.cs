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
    [ModelName("CollectionDescription")]
    [QueryName("CollectionDescription")]
    public class CollectionDescriptionModel : MutableModel
    {
        public static implicit operator CollectionDescriptionModel(
            Shared.Models.CollectionDomain.CollectionDescription entity
        )

        {
            return FromEntity(entity);
        }

        public static CollectionDescriptionModel
        FromEntity(Shared.Models.CollectionDomain.CollectionDescription entity)
        {
            return new CollectionDescriptionModel { Id = entity.Id };
        }

        public static List<CollectionDescriptionModel>
        FromEntityList(
            List<Shared.Models.CollectionDomain.CollectionDescription>
            entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (CollectionDescriptionModel) entity)
                .ToList();
        }

        public
        static implicit operator Shared.Models.CollectionDomain.CollectionDescription(
            CollectionDescriptionModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.CollectionDomain.CollectionDescription
        ToEntity(CollectionDescriptionModel model)
        {
            return new Shared.Models.CollectionDomain.CollectionDescription {
                Id = model.Id
            };
        }

        public static List<Shared.Models.CollectionDomain.CollectionDescription>
        ToEntityList(List<CollectionDescriptionModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity =>
                    (Shared.Models.CollectionDomain.CollectionDescription)
                    entity)
                .ToList();
        }
    }
}
