//
//  This file was automatically generated and should not be edited.
//  2020-02-25T11:04:53.588Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    [ModelName("Designation")]
    [QueryName("Designation")]
    public class DesignationModel : MutableModel
    {
        public static implicit operator DesignationModel(
            Shared.Models.Asset.Designation entity
        )

        {
            return FromEntity(entity);
        }

        public static DesignationModel
        FromEntity(Shared.Models.Asset.Designation entity)
        {
            return new DesignationModel { Id = entity.Id };
        }

        public static List<DesignationModel>
        FromEntityList(List<Shared.Models.Asset.Designation> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (DesignationModel) entity)
                .ToList();
        }
    }
}
