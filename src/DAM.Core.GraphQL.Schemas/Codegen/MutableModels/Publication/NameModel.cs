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
    [ModelName("Name")]
    [QueryName("Name")]
    public class NameModel : MutableModel
    {
        public static implicit operator NameModel(
            Shared.Models.PublicationDomain.Name entity
        )

        {
            return FromEntity(entity);
        }

        public static NameModel
        FromEntity(Shared.Models.PublicationDomain.Name entity)
        {
            return new NameModel { Id = entity.Id };
        }

        public static List<NameModel>
        FromEntityList(List<Shared.Models.PublicationDomain.Name> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (NameModel) entity).ToList();
        }

        public static implicit operator Shared.Models.PublicationDomain.Name(
            NameModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.PublicationDomain.Name
        ToEntity(NameModel model)
        {
            return new Shared.Models.PublicationDomain.Name { Id = model.Id };
        }

        public static List<Shared.Models.PublicationDomain.Name>
        ToEntityList(List<NameModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity => (Shared.Models.PublicationDomain.Name) entity)
                .ToList();
        }
    }
}
