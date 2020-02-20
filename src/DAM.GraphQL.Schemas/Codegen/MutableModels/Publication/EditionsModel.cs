//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.196Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BlobStorage.DB.Interfaces;

namespace DAM.GraphQL.Schemas.Publication
{
    [ModelName("Editions")]
    [QueryName("Editions")]
    public class EditionsModel : MutableModel
    {
        private Guid _name;

        private List<LanguagesModel> _languages;

        public Guid Name
        {
            get
            {
                return _name;
            }
            set
            {
                SetField(ref _name, value);
            }
        }

        public List<LanguagesModel> Languages
        {
            get
            {
                return _languages;
            }
            set
            {
                SetField(ref _languages, value);
            }
        }

        public static implicit operator EditionsModel(
            Services.Models.Publication.Editions entity
        )

        {
            return FromEntity(entity);
        }

        public static EditionsModel
        FromEntity(Services.Models.Publication.Editions entity)
        {
            return new EditionsModel {
                Id = entity.Id,
                _name = entity.Name,
                _languages = LanguagesModel.FromEntityList(entity.Languages)
            };
        }

        public static List<EditionsModel>
        FromEntityList(List<Services.Models.Publication.Editions> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (EditionsModel) entity).ToList();
        }
    }
}
