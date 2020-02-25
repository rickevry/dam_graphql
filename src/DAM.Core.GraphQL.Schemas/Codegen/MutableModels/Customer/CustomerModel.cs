//
//  This file was automatically generated and should not be edited.
//  2020-02-25T11:04:52.807Z
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Customer
{
    [ModelName("Customer")]
    [QueryName("Customer")]
    public class CustomerModel : MutableModel
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

        public static implicit operator CustomerModel(
            Shared.Models.Customer.Customer entity
        )

        {
            return FromEntity(entity);
        }

        public static CustomerModel
        FromEntity(Shared.Models.Customer.Customer entity)
        {
            return new CustomerModel {
                Id = entity.Id,
                _createdDate = entity.CreatedDate,
                _createdBy = entity.CreatedBy,
                _modifiedDate = entity.ModifiedDate,
                _modifiedBy = entity.ModifiedBy
            };
        }

        public static List<CustomerModel>
        FromEntityList(List<Shared.Models.Customer.Customer> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (CustomerModel) entity).ToList();
        }
    }
}
