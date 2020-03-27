//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.CollectionDomain;

namespace DAM.Core.GraphQL.Schemas.CollectionDomain
{
    [ModelName("CoverAssetId")]
    [QueryName("CoverAssetId")]
    public class CoverAssetIdModel : MutableModel
    {
        public static implicit operator CoverAssetIdModel(
            Shared.Models.CollectionDomain.CoverAssetId entity
        )

        {
            return FromEntity(entity);
        }

        public static CoverAssetIdModel
        FromEntity(Shared.Models.CollectionDomain.CoverAssetId entity)
        {
            return new CoverAssetIdModel { Id = entity.Id };
        }

        public static List<CoverAssetIdModel>
        FromEntityList(
            List<Shared.Models.CollectionDomain.CoverAssetId> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (CoverAssetIdModel) entity)
                .ToList();
        }

        public
        static implicit operator Shared.Models.CollectionDomain.CoverAssetId(
            CoverAssetIdModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.CollectionDomain.CoverAssetId
        ToEntity(CoverAssetIdModel model)
        {
            return new Shared.Models.CollectionDomain.CoverAssetId {
                Id = model.Id
            };
        }

        public static List<Shared.Models.CollectionDomain.CoverAssetId>
        ToEntityList(List<CoverAssetIdModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity =>
                    (Shared.Models.CollectionDomain.CoverAssetId) entity)
                .ToList();
        }
    }
}
