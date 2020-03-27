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
    [ModelName("Isocode")]
    [QueryName("Isocode")]
    public class IsocodeModel : MutableModel
    {
        public static implicit operator IsocodeModel(
            Shared.Models.SampleDomain.Isocode entity
        )

        {
            return FromEntity(entity);
        }

        public static IsocodeModel
        FromEntity(Shared.Models.SampleDomain.Isocode entity)
        {
            return new IsocodeModel { Id = entity.Id };
        }

        public static List<IsocodeModel>
        FromEntityList(List<Shared.Models.SampleDomain.Isocode> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (IsocodeModel) entity).ToList();
        }

        public static implicit operator Shared.Models.SampleDomain.Isocode(
            IsocodeModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.SampleDomain.Isocode
        ToEntity(IsocodeModel model)
        {
            return new Shared.Models.SampleDomain.Isocode { Id = model.Id };
        }

        public static List<Shared.Models.SampleDomain.Isocode>
        ToEntityList(List<IsocodeModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity => (Shared.Models.SampleDomain.Isocode) entity)
                .ToList();
        }
    }
}
