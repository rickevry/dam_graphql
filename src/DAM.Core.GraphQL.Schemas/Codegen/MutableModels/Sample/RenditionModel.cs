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
    [ModelName("Rendition")]
    [QueryName("Rendition")]
    public class RenditionModel : MutableModel
    {
        public static implicit operator RenditionModel(
            Shared.Models.SampleDomain.Rendition entity
        )

        {
            return FromEntity(entity);
        }

        public static RenditionModel
        FromEntity(Shared.Models.SampleDomain.Rendition entity)
        {
            return new RenditionModel { Id = entity.Id };
        }

        public static List<RenditionModel>
        FromEntityList(List<Shared.Models.SampleDomain.Rendition> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (RenditionModel) entity)
                .ToList();
        }

        public static implicit operator Shared.Models.SampleDomain.Rendition(
            RenditionModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.SampleDomain.Rendition
        ToEntity(RenditionModel model)
        {
            return new Shared.Models.SampleDomain.Rendition { Id = model.Id };
        }

        public static List<Shared.Models.SampleDomain.Rendition>
        ToEntityList(List<RenditionModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity => (Shared.Models.SampleDomain.Rendition) entity)
                .ToList();
        }
    }
}
