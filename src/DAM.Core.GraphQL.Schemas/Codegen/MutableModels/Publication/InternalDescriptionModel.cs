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
    [ModelName("InternalDescription")]
    [QueryName("InternalDescription")]
    public class InternalDescriptionModel : MutableModel
    {
        public static implicit operator InternalDescriptionModel(
            Shared.Models.PublicationDomain.InternalDescription entity
        )

        {
            return FromEntity(entity);
        }

        public static InternalDescriptionModel
        FromEntity(Shared.Models.PublicationDomain.InternalDescription entity)
        {
            return new InternalDescriptionModel { Id = entity.Id };
        }

        public static List<InternalDescriptionModel>
        FromEntityList(
            List<Shared.Models.PublicationDomain.InternalDescription> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (InternalDescriptionModel) entity)
                .ToList();
        }

        public
        static implicit operator Shared.Models.PublicationDomain.InternalDescription(
            InternalDescriptionModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.PublicationDomain.InternalDescription
        ToEntity(InternalDescriptionModel model)
        {
            return new Shared.Models.PublicationDomain.InternalDescription {
                Id = model.Id
            };
        }

        public static List<Shared.Models.PublicationDomain.InternalDescription>
        ToEntityList(List<InternalDescriptionModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity =>
                    (Shared.Models.PublicationDomain.InternalDescription)
                    entity)
                .ToList();
        }
    }
}
