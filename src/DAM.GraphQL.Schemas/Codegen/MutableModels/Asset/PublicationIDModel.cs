//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.450Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("PublicationID")]
    [QueryName("PublicationID")]
    public class PublicationIDModel : MutableModel
    {
        public static implicit operator PublicationIDModel(
            Services.Models.Asset.PublicationID entity
        )

        {
            return FromEntity(entity);
        }

        public static PublicationIDModel
        FromEntity(Services.Models.Asset.PublicationID entity)
        {
            return new PublicationIDModel { Id = entity.Id };
        }

        public static List<PublicationIDModel>
        FromEntityList(List<Services.Models.Asset.PublicationID> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (PublicationIDModel) entity)
                .ToList();
        }
    }
}
