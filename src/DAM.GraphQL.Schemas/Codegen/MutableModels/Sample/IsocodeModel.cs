//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.609Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Sample
{
    [ModelName("Isocode")]
    [QueryName("Isocode")]
    public class IsocodeModel : MutableModel
    {
        public static implicit operator IsocodeModel(
            Services.Models.Sample.Isocode entity
        )

        {
            return FromEntity(entity);
        }

        public static IsocodeModel
        FromEntity(Services.Models.Sample.Isocode entity)
        {
            return new IsocodeModel { Id = entity.Id };
        }

        public static List<IsocodeModel>
        FromEntityList(List<Services.Models.Sample.Isocode> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (IsocodeModel) entity).ToList();
        }
    }
}
