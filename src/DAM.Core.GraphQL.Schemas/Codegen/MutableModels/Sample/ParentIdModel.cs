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
    [ModelName("ParentId")]
    [QueryName("ParentId")]
    public class ParentIdModel : MutableModel
    {
        public static implicit operator ParentIdModel(
            Shared.Models.SampleDomain.ParentId entity
        )

        {
            return FromEntity(entity);
        }

        public static ParentIdModel
        FromEntity(Shared.Models.SampleDomain.ParentId entity)
        {
            return new ParentIdModel { Id = entity.Id };
        }

        public static List<ParentIdModel>
        FromEntityList(List<Shared.Models.SampleDomain.ParentId> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (ParentIdModel) entity).ToList();
        }

        public static implicit operator Shared.Models.SampleDomain.ParentId(
            ParentIdModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.SampleDomain.ParentId
        ToEntity(ParentIdModel model)
        {
            return new Shared.Models.SampleDomain.ParentId { Id = model.Id };
        }

        public static List<Shared.Models.SampleDomain.ParentId>
        ToEntityList(List<ParentIdModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity => (Shared.Models.SampleDomain.ParentId) entity)
                .ToList();
        }
    }
}
