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
    [ModelName("PublicationId")]
    [QueryName("PublicationId")]
    public class PublicationIdModel : MutableModel
    {
        public static implicit operator PublicationIdModel(
            Shared.Models.PublicationDomain.PublicationId entity
        )

        {
            return FromEntity(entity);
        }

        public static PublicationIdModel
        FromEntity(Shared.Models.PublicationDomain.PublicationId entity)
        {
            return new PublicationIdModel { Id = entity.Id };
        }

        public static List<PublicationIdModel>
        FromEntityList(
            List<Shared.Models.PublicationDomain.PublicationId> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (PublicationIdModel) entity)
                .ToList();
        }

        public
        static implicit operator Shared.Models.PublicationDomain.PublicationId(
            PublicationIdModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.PublicationDomain.PublicationId
        ToEntity(PublicationIdModel model)
        {
            return new Shared.Models.PublicationDomain.PublicationId {
                Id = model.Id
            };
        }

        public static List<Shared.Models.PublicationDomain.PublicationId>
        ToEntityList(List<PublicationIdModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity =>
                    (Shared.Models.PublicationDomain.PublicationId) entity)
                .ToList();
        }
    }
}
