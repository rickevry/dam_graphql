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
            Shared.Models.PublicationDomain.Editions entity
        )

        {
            return FromEntity(entity);
        }

        public static EditionsModel
        FromEntity(Shared.Models.PublicationDomain.Editions entity)
        {
            return new EditionsModel {
                Id = entity.Id,
                _name = entity.Name,
                _languages = LanguagesModel.FromEntityList(entity.Languages)
            };
        }

        public static List<EditionsModel>
        FromEntityList(
            List<Shared.Models.PublicationDomain.Editions> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (EditionsModel) entity).ToList();
        }

        public
        static implicit operator Shared.Models.PublicationDomain.Editions(
            EditionsModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.PublicationDomain.Editions
        ToEntity(EditionsModel model)
        {
            return new Shared.Models.PublicationDomain.Editions {
                Id = model.Id,
                Name = model._name,
                Languages = LanguagesModel.ToEntityList(model._languages)
            };
        }

        public static List<Shared.Models.PublicationDomain.Editions>
        ToEntityList(List<EditionsModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity =>
                    (Shared.Models.PublicationDomain.Editions) entity)
                .ToList();
        }
    }
}
