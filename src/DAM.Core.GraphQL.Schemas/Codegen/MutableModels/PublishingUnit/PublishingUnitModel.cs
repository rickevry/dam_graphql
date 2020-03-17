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
    [ModelName("PublishingUnit")]
    [QueryName("publishingUnits")]
    public class PublishingUnitModel : MutableModel
    {
        private List<Folder> _folders;

        private string _title;

        private DateTime _createdDate;

        private Guid _createdBy;

        private DateTime _modifiedDate;

        private Guid _modifiedBy;

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

        public static implicit operator PublishingUnitModel(
            Shared.Models.PublishingUnitDomain.PublishingUnit entity
        )

        {
            return FromEntity(entity);
        }

        public static PublishingUnitModel
        FromEntity(Shared.Models.PublishingUnitDomain.PublishingUnit entity)
        {
            return new PublishingUnitModel {
                Id = entity.Id,
                _folders = entity.Folders,
                _title = entity.Title,
                _createdDate = entity.CreatedDate,
                _createdBy = entity.CreatedBy,
                _modifiedDate = entity.ModifiedDate,
                _modifiedBy = entity.ModifiedBy
            };
        }

        public static List<PublishingUnitModel>
        FromEntityList(
            List<Shared.Models.PublishingUnitDomain.PublishingUnit> entityList
        )
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList
                .Select(entity => (PublishingUnitModel) entity)
                .ToList();
        }
    }
}
