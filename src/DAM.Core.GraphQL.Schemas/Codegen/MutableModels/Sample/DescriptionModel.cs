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
    [ModelName("Asset")]
    [QueryName("assets")]
    public class DescriptionModel : MutableModel
    {
        public static implicit operator DescriptionModel(
            Shared.Models.SampleDomain.Description entity
        )

        {
            return FromEntity(entity);
        }

        public static DescriptionModel
        FromEntity(Shared.Models.SampleDomain.Description entity)
        {
            return new DescriptionModel { Id = entity.Id };
        }

        public static List<DescriptionModel>
        FromEntityList(List<Shared.Models.SampleDomain.Description> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (DescriptionModel) entity)
                .ToList();
        }

        public static implicit operator Shared.Models.SampleDomain.Description(
            DescriptionModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.SampleDomain.Description
        ToEntity(DescriptionModel model)
        {
            return new Shared.Models.SampleDomain.Description { Id = model.Id };
        }

        public static List<Shared.Models.SampleDomain.Description>
        ToEntityList(List<DescriptionModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity =>
                    (Shared.Models.SampleDomain.Description) entity)
                .ToList();
        }
    }
}
