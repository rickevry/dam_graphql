//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:17.285Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Asset;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("RightsManagedDescription")]
    [QueryName("RightsManagedDescription")]
    public class RightsManagedDescriptionModel : MutableModel
    {
        public static implicit operator RightsManagedDescriptionModel(
            Services.Models.Asset.RightsManagedDescription entity
        )

        {
            return FromEntity(entity);
        }

        public static RightsManagedDescriptionModel
        FromEntity(Services.Models.Asset.RightsManagedDescription entity)
        {
            return new RightsManagedDescriptionModel { Id = entity.Id };
        }

        public static List<RightsManagedDescriptionModel>
        FromEntityList(
            List<Services.Models.Asset.RightsManagedDescription> entityList
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
