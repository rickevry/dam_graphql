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
    [ModelName("AssetType")]
    [QueryName("AssetType")]
    public class AssetTypeModel : MutableModel
    {
        public static implicit operator AssetTypeModel(
            Shared.Models.PublicationDomain.AssetType entity
        )

        {
            return FromEntity(entity);
        }

        public static AssetTypeModel
        FromEntity(Shared.Models.PublicationDomain.AssetType entity)
        {
            return new AssetTypeModel { Id = entity.Id };
        }

        public static List<AssetTypeModel>
        FromEntityList(
            List<Shared.Models.PublicationDomain.AssetType> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (AssetTypeModel) entity)
                .ToList();
        }

        public
        static implicit operator Shared.Models.PublicationDomain.AssetType(
            AssetTypeModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.PublicationDomain.AssetType
        ToEntity(AssetTypeModel model)
        {
            return new Shared.Models.PublicationDomain.AssetType {
                Id = model.Id
            };
        }

        public static List<Shared.Models.PublicationDomain.AssetType>
        ToEntityList(List<AssetTypeModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity =>
                    (Shared.Models.PublicationDomain.AssetType) entity)
                .ToList();
        }
    }
}
