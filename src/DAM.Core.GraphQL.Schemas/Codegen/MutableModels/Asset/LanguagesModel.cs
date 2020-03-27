//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.AssetDomain;

namespace DAM.Core.GraphQL.Schemas.AssetDomain
{
    [ModelName("Languages")]
    [QueryName("Languages")]
    public class LanguagesModel : MutableModel
    {
        private string _isoCode;

        private string _description;

        public string IsoCode
        {
            get
            {
                return _isoCode;
            }
            set
            {
                SetField(ref _isoCode, value);
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                SetField(ref _description, value);
            }
        }

        public static implicit operator LanguagesModel(
            Shared.Models.AssetDomain.Languages entity
        )

        {
            return FromEntity(entity);
        }

        public static LanguagesModel
        FromEntity(Shared.Models.AssetDomain.Languages entity)
        {
            return new LanguagesModel {
                Id = entity.Id,
                _isoCode = entity.IsoCode,
                _description = entity.Description
            };
        }

        public static List<LanguagesModel>
        FromEntityList(List<Shared.Models.AssetDomain.Languages> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (LanguagesModel) entity)
                .ToList();
        }

        public static implicit operator Shared.Models.AssetDomain.Languages(
            LanguagesModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.AssetDomain.Languages
        ToEntity(LanguagesModel model)
        {
            return new Shared.Models.AssetDomain.Languages {
                Id = model.Id,
                IsoCode = model._isoCode,
                Description = model._description
            };
        }

        public static List<Shared.Models.AssetDomain.Languages>
        ToEntityList(List<LanguagesModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity => (Shared.Models.AssetDomain.Languages) entity)
                .ToList();
        }
    }
}
