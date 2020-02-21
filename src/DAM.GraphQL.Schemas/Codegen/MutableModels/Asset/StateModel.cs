//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.833Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("State")]
    [QueryName("State")]
    public class StateModel : MutableModel
    {
        public static implicit operator StateModel(
            Services.Models.Asset.State entity
        )

        {
            return FromEntity(entity);
        }

        public static StateModel FromEntity(Services.Models.Asset.State entity)
        {
            return new StateModel { Id = entity.Id };
        }

        public static List<StateModel>
        FromEntityList(List<Services.Models.Asset.State> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (StateModel) entity).ToList();
        }
    }
}
