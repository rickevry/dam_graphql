//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.746Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Asset
{
    [ModelName("PublicationDesignation")]
    [QueryName("PublicationDesignation")]
    public class PublicationDesignationModel : MutableModel
    {
        public static implicit operator PublicationDesignationModel(
            Services.Models.Asset.PublicationDesignation entity
        )

        {
            return FromEntity(entity);
        }

        public static PublicationDesignationModel
        FromEntity(Services.Models.Asset.PublicationDesignation entity)
        {
            return new PublicationDesignationModel { Id = entity.Id };
        }

        public static List<PublicationDesignationModel>
        FromEntityList(
            List<Services.Models.Asset.PublicationDesignation> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (PublicationDesignationModel) entity)
                .ToList();
        }
    }
}
