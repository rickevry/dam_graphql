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
    [ModelName("Assets")]
    [QueryName("Assets")]
    public class AssetsModel : MutableModel
    {
        public static implicit operator AssetsModel(
            Shared.Models.PublicationDomain.Assets entity
        )

        {
            return FromEntity(entity);
        }

        public static AssetsModel
        FromEntity(Shared.Models.PublicationDomain.Assets entity)
        {
            return new AssetsModel { Id = entity.Id };
        }

        public static List<AssetsModel>
        FromEntityList(List<Shared.Models.PublicationDomain.Assets> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (AssetsModel) entity).ToList();
        }

        public static implicit operator Shared.Models.PublicationDomain.Assets(
            AssetsModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.PublicationDomain.Assets
        ToEntity(AssetsModel model)
        {
            return new Shared.Models.PublicationDomain.Assets { Id = model.Id };
        }

        public static List<Shared.Models.PublicationDomain.Assets>
        ToEntityList(List<AssetsModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity =>
                    (Shared.Models.PublicationDomain.Assets) entity)
                .ToList();
        }
    }
}
