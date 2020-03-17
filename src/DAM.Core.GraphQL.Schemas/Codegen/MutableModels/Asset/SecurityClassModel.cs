//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.AssetDomain;

namespace DAM.Core.GraphQL.Schemas.AssetDomain
{
    [ModelName("SecurityClass")]
    [QueryName("SecurityClass")]
    public class SecurityClassModel : MutableModel
    {
        public static implicit operator SecurityClassModel(
            Shared.Models.AssetDomain.SecurityClass entity
        )

        {
            return FromEntity(entity);
        }

        public static SecurityClassModel
        FromEntity(Shared.Models.AssetDomain.SecurityClass entity)
        {
            return new SecurityClassModel { Id = entity.Id };
        }

        public static List<SecurityClassModel>
        FromEntityList(List<Shared.Models.AssetDomain.SecurityClass> entityList)
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
