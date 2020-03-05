//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.Asset;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    [ModelName("ReleaseForm")]
    [QueryName("releaseForm")]
    public class ReleaseFormModel : MutableModel
    {
        private bool _modelReleaseForms;

        private bool _generalReleaseForms;

        public bool modelReleaseForms
        {
            get
            {
                return _modelReleaseForms;
            }
            set
            {
                SetField(ref _modelReleaseForms, value);
            }
        }

        public bool generalReleaseForms
        {
            get
            {
                return _generalReleaseForms;
            }
            set
            {
                SetField(ref _generalReleaseForms, value);
            }
        }

        public static implicit operator ReleaseFormModel(
            Shared.Models.Asset.ReleaseForm entity
        )

        {
            return FromEntity(entity);
        }

        public static ReleaseFormModel
        FromEntity(Shared.Models.Asset.ReleaseForm entity)
        {
            return new ReleaseFormModel {
                Id = entity.Id,
                _modelReleaseForms = entity.modelReleaseForms,
                _generalReleaseForms = entity.generalReleaseForms
            };
        }

        public static List<ReleaseFormModel>
        FromEntityList(List<Shared.Models.Asset.ReleaseForm> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (ReleaseFormModel) entity)
                .ToList();
        }
    }
}
