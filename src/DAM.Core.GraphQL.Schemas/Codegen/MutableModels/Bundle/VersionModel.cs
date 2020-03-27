//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.BundleDomain;

namespace DAM.Core.GraphQL.Schemas.BundleDomain
{
    [ModelName("Version")]
    [QueryName("versions")]
    public class VersionModel : MutableModel
    {
        public static implicit operator VersionModel(
            Shared.Models.BundleDomain.Version entity
        )

        {
            return FromEntity(entity);
        }

        public static VersionModel
        FromEntity(Shared.Models.BundleDomain.Version entity)
        {
            return new VersionModel { Id = entity.Id };
        }

        public static List<VersionModel>
        FromEntityList(List<Shared.Models.BundleDomain.Version> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (VersionModel) entity).ToList();
        }

        public static implicit operator Shared.Models.BundleDomain.Version(
            VersionModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.BundleDomain.Version
        ToEntity(VersionModel model)
        {
            return new Shared.Models.BundleDomain.Version { Id = model.Id };
        }

        public static List<Shared.Models.BundleDomain.Version>
        ToEntityList(List<VersionModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity => (Shared.Models.BundleDomain.Version) entity)
                .ToList();
        }
    }
}
