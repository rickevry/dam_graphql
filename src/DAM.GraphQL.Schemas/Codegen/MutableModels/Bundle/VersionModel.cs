//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:06.816Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Bundle
{
    [ModelName("Version")]
    [QueryName("versions")]
    public class VersionModel : MutableModel
    {
        public static implicit operator VersionModel(
            Services.Models.Bundle.Version entity
        )

        {
            return FromEntity(entity);
        }

        public static VersionModel
        FromEntity(Services.Models.Bundle.Version entity)
        {
            return new VersionModel { Id = entity.Id };
        }

        public static List<VersionModel>
        FromEntityList(List<Services.Models.Bundle.Version> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (VersionModel) entity).ToList();
        }
    }
}
