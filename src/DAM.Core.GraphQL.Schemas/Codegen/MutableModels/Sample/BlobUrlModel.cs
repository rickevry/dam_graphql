//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.SampleDomain;

namespace DAM.Core.GraphQL.Schemas.SampleDomain
{
    [ModelName("BlobUrl")]
    [QueryName("BlobUrl")]
    public class BlobUrlModel : MutableModel
    {
        public static implicit operator BlobUrlModel(
            Shared.Models.SampleDomain.BlobUrl entity
        )

        {
            return FromEntity(entity);
        }

        public static BlobUrlModel
        FromEntity(Shared.Models.SampleDomain.BlobUrl entity)
        {
            return new BlobUrlModel { Id = entity.Id };
        }

        public static List<BlobUrlModel>
        FromEntityList(List<Shared.Models.SampleDomain.BlobUrl> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (BlobUrlModel) entity).ToList();
        }

        public static implicit operator Shared.Models.SampleDomain.BlobUrl(
            BlobUrlModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.SampleDomain.BlobUrl
        ToEntity(BlobUrlModel model)
        {
            return new Shared.Models.SampleDomain.BlobUrl { Id = model.Id };
        }

        public static List<Shared.Models.SampleDomain.BlobUrl>
        ToEntityList(List<BlobUrlModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity => (Shared.Models.SampleDomain.BlobUrl) entity)
                .ToList();
        }
    }
}
