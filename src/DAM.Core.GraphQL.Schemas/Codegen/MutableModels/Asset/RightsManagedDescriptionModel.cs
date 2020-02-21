//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:58.903Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    [ModelName("RightsManagedDescription")]
    [QueryName("RightsManagedDescription")]
    public class RightsManagedDescriptionModel : MutableModel
    {
        public static implicit operator RightsManagedDescriptionModel(
            Shared.Models.Asset.RightsManagedDescription entity
        )

        {
            return FromEntity(entity);
        }

        public static RightsManagedDescriptionModel
        FromEntity(Shared.Models.Asset.RightsManagedDescription entity)
        {
            return new RightsManagedDescriptionModel { Id = entity.Id };
        }

        public static List<RightsManagedDescriptionModel>
        FromEntityList(
            List<Shared.Models.Asset.RightsManagedDescription> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (RightsManagedDescriptionModel) entity)
                .ToList();
        }
    }
}
