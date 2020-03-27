//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.FolderDomain;
using DAM.Core.Shared.Models.PersonDomain;

namespace DAM.Core.GraphQL.Schemas.FolderDomain
{
    [ModelName("Folder")]
    [QueryName("folder")]
    public class FolderModel : MutableModel
    {
        private Guid? _parentId;

        private DateTime _createdDate;

        private string _createdBy;

        private string _title;

        public Guid? ParentId
        {
            get
            {
                return _parentId;
            }
            set
            {
                SetField(ref _parentId, value);
            }
        }

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

        public string CreatedBy
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

        public static implicit operator FolderModel(
            Shared.Models.FolderDomain.Folder entity
        )

        {
            return FromEntity(entity);
        }

        public static FolderModel
        FromEntity(Shared.Models.FolderDomain.Folder entity)
        {
            return new FolderModel
            {
                Id = entity.Id,
                _parentId = entity.ParentId,
                _createdDate = entity.CreatedDate,
                _createdBy = entity.CreatedBy,
                _title = entity.Title,
            };
        }

        public static List<FolderModel>
        FromEntityList(List<Shared.Models.FolderDomain.Folder> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (FolderModel)entity).ToList();
        }

        public static implicit operator Shared.Models.FolderDomain.Folder(
            FolderModel entity
        )

        {
            return ToEntity(entity);
        }

        public static Shared.Models.FolderDomain.Folder
        ToEntity(FolderModel entity)
        {
            return new Folder
            {
                Id = entity.Id,
                ParentId = entity.ParentId,
                CreatedDate = entity._createdDate,
                CreatedBy = entity._createdBy,
                Title = entity._title,
            };
        }

        public static List<Shared.Models.FolderDomain.Folder>
        ToEntityList(List<FolderModel> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (Shared.Models.FolderDomain.Folder)entity).ToList();
        }
    }
}
