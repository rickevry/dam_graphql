//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:16.879Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Services.Models.Publication;

namespace DAM.GraphQL.Schemas.Publication
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
            Services.Models.Publication.Languages entity
        )

        {
            return FromEntity(entity);
        }

        public static LanguagesModel
        FromEntity(Services.Models.Publication.Languages entity)
        {
            return new LanguagesModel {
                Id = entity.Id,
                _language = entity.Language,
                _assets = AssetsModel.FromEntityList(entity.Assets)
            };
        }

        public static List<LanguagesModel>
        FromEntityList(List<Services.Models.Publication.Languages> entityList)
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
