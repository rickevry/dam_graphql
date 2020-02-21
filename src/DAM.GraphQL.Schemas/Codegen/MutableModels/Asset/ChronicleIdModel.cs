//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.252Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("ChronicleId")]
    [QueryName("ChronicleId")]
    public class ChronicleIdModel : MutableModel
    {
        public static implicit operator ChronicleIdModel(
            Services.Models.Asset.ChronicleId entity
        )

        {
            return FromEntity(entity);
        }

        public static ChronicleIdModel
        FromEntity(Services.Models.Asset.ChronicleId entity)
        {
            return new ChronicleIdModel { Id = entity.Id };
        }

        public static List<ChronicleIdModel>
        FromEntityList(List<Services.Models.Asset.ChronicleId> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (ChronicleIdModel) entity)
                .ToList();
        }
    }
}
