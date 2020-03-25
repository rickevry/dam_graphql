//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.PersonDomain;

namespace DAM.Core.GraphQL.Schemas.FolderDomain
{
    [ModelName("Folder")]
    [QueryName("folder")]
    public class FolderModel : MutableModel
    {
        private DateTime _createdDate;

        private string _createdBy;

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
                _createdDate = entity.CreatedDate,
                _createdBy = entity.CreatedBy,
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
    }
}
