//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.SampleDomain;

namespace DAM.Core.GraphQL.Schemas.SampleDomain
{
    [ModelName("AssetType")]
    [QueryName("AssetType")]
    public class AssetTypeModel : MutableModel
    {
        public static implicit operator AssetTypeModel(
            Shared.Models.SampleDomain.AssetType entity
        )

        {
            return FromEntity(entity);
        }

        public static AssetTypeModel
        FromEntity(Shared.Models.SampleDomain.AssetType entity)
        {
            return new AssetTypeModel { Id = entity.Id };
        }

        public static List<AssetTypeModel>
        FromEntityList(List<Shared.Models.SampleDomain.AssetType> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (AssetTypeModel) entity)
                .ToList();
        }

        public static implicit operator Shared.Models.SampleDomain.AssetType(
            AssetTypeModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.SampleDomain.AssetType
        ToEntity(AssetTypeModel model)
        {
            return new Shared.Models.SampleDomain.AssetType { Id = model.Id };
        }

        public static List<Shared.Models.SampleDomain.AssetType>
        ToEntityList(List<AssetTypeModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity => (Shared.Models.SampleDomain.AssetType) entity)
                .ToList();
        }
    }
}
