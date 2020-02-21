//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.524Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("SecurityClass")]
    [QueryName("SecurityClass")]
    public class SecurityClassModel : MutableModel
    {
        public static implicit operator SecurityClassModel(
            Services.Models.Asset.SecurityClass entity
        )

        {
            return FromEntity(entity);
        }

        public static SecurityClassModel
        FromEntity(Services.Models.Asset.SecurityClass entity)
        {
            return new SecurityClassModel { Id = entity.Id };
        }

        public static List<SecurityClassModel>
        FromEntityList(List<Services.Models.Asset.SecurityClass> entityList)
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
