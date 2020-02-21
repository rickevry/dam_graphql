//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:16.941Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Publication;

namespace DAM.GraphQL.Schemas.Publication
{
    [ModelName("ModifyDate")]
    [QueryName("ModifyDate")]
    public class ModifyDateModel : MutableModel
    {
        public static implicit operator ModifyDateModel(
            Services.Models.Publication.ModifyDate entity
        )

        {
            return FromEntity(entity);
        }

        public static ModifyDateModel
        FromEntity(Services.Models.Publication.ModifyDate entity)
        {
            return new ModifyDateModel { Id = entity.Id };
        }

        public static List<ModifyDateModel>
        FromEntityList(List<Services.Models.Publication.ModifyDate> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (ModifyDateModel) entity)
                .ToList();
        }
    }
}
