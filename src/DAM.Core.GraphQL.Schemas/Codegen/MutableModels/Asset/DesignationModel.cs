//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.AssetDomain;

namespace DAM.Core.GraphQL.Schemas.AssetDomain
{
    [ModelName("Designation")]
    [QueryName("Designation")]
    public class DesignationModel : MutableModel
    {
        public static implicit operator DesignationModel(
            Shared.Models.AssetDomain.Designation entity
        )

        {
            return FromEntity(entity);
        }

        public static DesignationModel
        FromEntity(Shared.Models.AssetDomain.Designation entity)
        {
            return new DesignationModel { Id = entity.Id };
        }

        public static List<DesignationModel>
        FromEntityList(List<Shared.Models.AssetDomain.Designation> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (DesignationModel) entity)
                .ToList();
        }

        public static implicit operator Shared.Models.AssetDomain.Designation(
            DesignationModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.AssetDomain.Designation
        ToEntity(DesignationModel model)
        {
            return new Shared.Models.AssetDomain.Designation { Id = model.Id };
        }

        public static List<Shared.Models.AssetDomain.Designation>
        ToEntityList(List<DesignationModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity =>
                    (Shared.Models.AssetDomain.Designation) entity)
                .ToList();
        }
    }
}
