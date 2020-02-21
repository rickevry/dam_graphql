//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:57.890Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Publication
{
    [ModelName("ModifyDate")]
    [QueryName("ModifyDate")]
    public class ModifyDateModel : MutableModel
    {
        public static implicit operator ModifyDateModel(
            Shared.Models.Publication.ModifyDate entity
        )

        {
            return FromEntity(entity);
        }

        public static ModifyDateModel
        FromEntity(Shared.Models.Publication.ModifyDate entity)
        {
            return new ModifyDateModel { Id = entity.Id };
        }

        public static List<ModifyDateModel>
        FromEntityList(List<Shared.Models.Publication.ModifyDate> entityList)
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
