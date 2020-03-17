//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.PersonDomain;

namespace DAM.Core.GraphQL.Schemas.PersonDomain
{
    [ModelName("Person")]
    [QueryName("person")]
    public class PersonModel : MutableModel
    {
        private DateTime _createdDate;

        private Guid _createdBy;

        private DateTime _modifiedDate;

        private Guid _modifiedBy;

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

        public static implicit operator PersonModel(
            Shared.Models.PersonDomain.Person entity
        )

        {
            return FromEntity(entity);
        }

        public static PersonModel
        FromEntity(Shared.Models.PersonDomain.Person entity)
        {
            return new PersonModel {
                Id = entity.Id,
                _createdDate = entity.CreatedDate,
                _createdBy = entity.CreatedBy,
                _modifiedDate = entity.ModifiedDate,
                _modifiedBy = entity.ModifiedBy
            };
        }

        public static List<PersonModel>
        FromEntityList(List<Shared.Models.PersonDomain.Person> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (PersonModel) entity).ToList();
        }
    }
}
