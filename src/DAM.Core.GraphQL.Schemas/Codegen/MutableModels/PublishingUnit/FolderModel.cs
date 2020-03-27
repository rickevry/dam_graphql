//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.PublishingUnitDomain;

namespace DAM.Core.GraphQL.Schemas.PublishingUnitDomain
{
    [ModelName("Folder")]
    [QueryName("Folder")]
    public class FolderModel : MutableModel
    {
        private DateTime _createdDate;

        private Guid _createdBy;

        private DateTime _modifiedDate;

        private string _title;

        private Guid _modifiedBy;

        private List<Folder> _folders;

        public DateTime CreatedDate
        {
            get
            {
                return _createdDate;
            }
            set
            {
                SetField(ref _createdDate, value);
            }
        }

        public Guid CreatedBy
        {
            get
            {
                return _createdBy;
            }
            set
            {
                SetField(ref _createdBy, value);
            }
        }

        public DateTime ModifiedDate
        {
            get
            {
                return _modifiedDate;
            }
            set
            {
                SetField(ref _modifiedDate, value);
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                SetField(ref _title, value);
            }
        }

        public Guid ModifiedBy
        {
            get
            {
                return _modifiedBy;
            }
            set
            {
                SetField(ref _modifiedBy, value);
            }
        }

        public List<Folder> Folders
        {
            get
            {
                return _folders;
            }
            set
            {
                SetField(ref _folders, value);
            }
        }

        public static implicit operator FolderModel(
            Shared.Models.PublishingUnitDomain.Folder entity
        )

        {
            return FromEntity(entity);
        }

        public static FolderModel
        FromEntity(Shared.Models.PublishingUnitDomain.Folder entity)
        {
            return new FolderModel {
                Id = entity.Id,
                _createdDate = entity.CreatedDate,
                _createdBy = entity.CreatedBy,
                _modifiedDate = entity.ModifiedDate,
                _title = entity.Title,
                _modifiedBy = entity.ModifiedBy,
                _folders = entity.Folders
            };
        }

        public static List<FolderModel>
        FromEntityList(
            List<Shared.Models.PublishingUnitDomain.Folder> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (FolderModel) entity).ToList();
        }

        public
        static implicit operator Shared.Models.PublishingUnitDomain.Folder(
            FolderModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.PublishingUnitDomain.Folder
        ToEntity(FolderModel model)
        {
            return new Shared.Models.PublishingUnitDomain.Folder {
                Id = model.Id,
                CreatedDate = model._createdDate,
                CreatedBy = model._createdBy,
                ModifiedDate = model._modifiedDate,
                Title = model._title,
                ModifiedBy = model._modifiedBy,
                Folders = model._folders
            };
        }

        public static List<Shared.Models.PublishingUnitDomain.Folder>
        ToEntityList(List<FolderModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity =>
                    (Shared.Models.PublishingUnitDomain.Folder) entity)
                .ToList();
        }
    }
}
