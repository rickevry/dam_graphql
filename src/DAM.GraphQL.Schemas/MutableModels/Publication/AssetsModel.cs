//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:16.894Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Publication;

namespace DAM.GraphQL.Schemas.Publication
{
    [ModelName("Assets")]
    [QueryName("Assets")]
    public class AssetsModel : MutableModel
    {
        public static implicit operator AssetsModel(
            Services.Models.Publication.Assets entity
        )

        {
            return FromEntity(entity);
        }

        public static AssetsModel
        FromEntity(Services.Models.Publication.Assets entity)
        {
            return new AssetsModel { Id = entity.Id };
        }

        public static List<AssetsModel>
        FromEntityList(List<Services.Models.Publication.Assets> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (AssetsModel) entity).ToList();
        }
    }
}
