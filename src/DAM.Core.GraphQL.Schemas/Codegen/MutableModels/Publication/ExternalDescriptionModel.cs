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
    [ModelName("ExternalDescription")]
    [QueryName("ExternalDescription")]
    public class ExternalDescriptionModel : MutableModel
    {
        public static implicit operator ExternalDescriptionModel(
            Shared.Models.PublicationDomain.ExternalDescription entity
        )

        {
            return FromEntity(entity);
        }

        public static ExternalDescriptionModel
        FromEntity(Shared.Models.PublicationDomain.ExternalDescription entity)
        {
            return new ExternalDescriptionModel { Id = entity.Id };
        }

        public static List<ExternalDescriptionModel>
        FromEntityList(
            List<Shared.Models.PublicationDomain.ExternalDescription> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (ExternalDescriptionModel) entity)
                .ToList();
        }

        public
        static implicit operator Shared.Models.PublicationDomain.ExternalDescription(
            ExternalDescriptionModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.PublicationDomain.ExternalDescription
        ToEntity(ExternalDescriptionModel model)
        {
            return new Shared.Models.PublicationDomain.ExternalDescription {
                Id = model.Id
            };
        }

        public static List<Shared.Models.PublicationDomain.ExternalDescription>
        ToEntityList(List<ExternalDescriptionModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity =>
                    (Shared.Models.PublicationDomain.ExternalDescription)
                    entity)
                .ToList();
        }
    }
}
