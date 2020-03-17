//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.PublicationDomain;

namespace DAM.Core.GraphQL.Schemas.PublicationDomain
{
    [ModelName("Languages")]
    [QueryName("Languages")]
    public class LanguagesModel : MutableModel
    {
        private LanguageModel _language;

        private List<AssetsModel> _assets;

        public LanguageModel Language
        {
            get
            {
                return _language;
            }
            set
            {
                SetField(ref _language, value);
            }
        }

        public List<AssetsModel> Assets
        {
            get
            {
                return _assets;
            }
            set
            {
                SetField(ref _assets, value);
            }
        }

        public static implicit operator LanguagesModel(
            Shared.Models.PublicationDomain.Languages entity
        )

        {
            return FromEntity(entity);
        }

        public static LanguagesModel
        FromEntity(Shared.Models.PublicationDomain.Languages entity)
        {
            return new LanguagesModel {
                Id = entity.Id,
                _language = entity.Language,
                _assets = AssetsModel.FromEntityList(entity.Assets)
            };
        }

        public static List<LanguagesModel>
        FromEntityList(
            List<Shared.Models.PublicationDomain.Languages> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (LanguagesModel) entity)
                .ToList();
        }
    }
}
