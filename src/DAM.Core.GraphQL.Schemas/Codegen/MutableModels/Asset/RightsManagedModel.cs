//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:58.817Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    [ModelName("RightsManaged")]
    [QueryName("RightsManaged")]
    public class RightsManagedModel : MutableModel
    {
        public static implicit operator RightsManagedModel(
            Shared.Models.Asset.RightsManaged entity
        )

        {
            return FromEntity(entity);
        }

        public static RightsManagedModel
        FromEntity(Shared.Models.Asset.RightsManaged entity)
        {
            return new RightsManagedModel { Id = entity.Id };
        }

        public static List<RightsManagedModel>
        FromEntityList(List<Shared.Models.Asset.RightsManaged> entityList)
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
