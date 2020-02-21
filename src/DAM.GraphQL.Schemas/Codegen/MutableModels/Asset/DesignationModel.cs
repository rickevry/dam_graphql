//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.811Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("Designation")]
    [QueryName("Designation")]
    public class DesignationModel : MutableModel
    {
        public static implicit operator DesignationModel(
            Services.Models.Asset.Designation entity
        )

        {
            return FromEntity(entity);
        }

        public static DesignationModel
        FromEntity(Services.Models.Asset.Designation entity)
        {
            return new DesignationModel { Id = entity.Id };
        }

        public static List<DesignationModel>
        FromEntityList(List<Services.Models.Asset.Designation> entityList)
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
