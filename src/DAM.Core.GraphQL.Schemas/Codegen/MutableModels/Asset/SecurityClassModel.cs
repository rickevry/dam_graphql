//
//  This file was automatically generated and should not be edited.
//  2020-02-25T11:04:53.479Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    [ModelName("SecurityClass")]
    [QueryName("SecurityClass")]
    public class SecurityClassModel : MutableModel
    {
        public static implicit operator SecurityClassModel(
            Shared.Models.Asset.SecurityClass entity
        )

        {
            return FromEntity(entity);
        }

        public static SecurityClassModel
        FromEntity(Shared.Models.Asset.SecurityClass entity)
        {
            return new SecurityClassModel { Id = entity.Id };
        }

        public static List<SecurityClassModel>
        FromEntityList(List<Shared.Models.Asset.SecurityClass> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (SecurityClassModel) entity)
                .ToList();
        }
    }
}
