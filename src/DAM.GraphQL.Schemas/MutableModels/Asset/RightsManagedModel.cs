//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:17.254Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Asset;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("RightsManaged")]
    [QueryName("RightsManaged")]
    public class RightsManagedModel : MutableModel
    {
        public static implicit operator RightsManagedModel(
            Services.Models.Asset.RightsManaged entity
        )

        {
            return FromEntity(entity);
        }

        public static RightsManagedModel
        FromEntity(Services.Models.Asset.RightsManaged entity)
        {
            return new RightsManagedModel { Id = entity.Id };
        }

        public static List<RightsManagedModel>
        FromEntityList(List<Services.Models.Asset.RightsManaged> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (RightsManagedModel) entity)
                .ToList();
        }
    }
}
