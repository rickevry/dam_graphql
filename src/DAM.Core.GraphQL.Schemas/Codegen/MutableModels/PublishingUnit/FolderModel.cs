//
//  This file was automatically generated and should not be edited.
//  2020-02-28T09:54:22.388Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.PublishingUnit;

namespace DAM.Core.GraphQL.Schemas.PublishingUnit
{
    [ModelName("Folder")]
    [QueryName("Folder")]
    public class FolderModel : MutableModel
    {
        private DateTime _createdDate;

        private Guid _createdBy;

        private DateTime _modifiedDate;

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
            Shared.Models.PublishingUnit.Folder entity
        )

        {
            return FromEntity(entity);
        }

        public static FolderModel
        FromEntity(Shared.Models.PublishingUnit.Folder entity)
        {
            return new FolderModel {
                Id = entity.Id,
                _createdDate = entity.CreatedDate,
                _createdBy = entity.CreatedBy,
                _modifiedDate = entity.ModifiedDate,
                _modifiedBy = entity.ModifiedBy,
                _folders = entity.Folders
            };
        }

        public static List<FolderModel>
        FromEntityList(List<Shared.Models.PublishingUnit.Folder> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (FolderModel) entity).ToList();
        }
    }
}
