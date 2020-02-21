//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:57.661Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Publication
{
    [ModelName("Assets")]
    [QueryName("Assets")]
    public class AssetsModel : MutableModel
    {
        public static implicit operator AssetsModel(
            Shared.Models.Publication.Assets entity
        )

        {
            return FromEntity(entity);
        }

        public static AssetsModel
        FromEntity(Shared.Models.Publication.Assets entity)
        {
            return new AssetsModel { Id = entity.Id };
        }

        public static List<AssetsModel>
        FromEntityList(List<Shared.Models.Publication.Assets> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (AssetsModel) entity).ToList();
        }
    }
}