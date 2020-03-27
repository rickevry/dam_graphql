//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DAM.Core.Shared.Models.CustomerDomain;

namespace DAM.Core.GraphQL.Schemas.CustomerDomain
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
            Shared.Models.CustomerDomain.Customer entity
        )

        {
            return FromEntity(entity);
        }

        public static CustomerModel
        FromEntity(Shared.Models.CustomerDomain.Customer entity)
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
        FromEntityList(List<Shared.Models.CustomerDomain.Customer> entityList)
        {
            if (entityList == null)
            {
                return null;
            }

            return entityList.Select(entity => (CustomerModel) entity).ToList();
        }

        public static implicit operator Shared.Models.CustomerDomain.Customer(
            CustomerModel model
        )

        {
            return ToEntity(model);
        }

        public static Shared.Models.CustomerDomain.Customer
        ToEntity(CustomerModel model)
        {
            return new Shared.Models.CustomerDomain.Customer {
                Id = model.Id,
                CreatedDate = model._createdDate,
                CreatedBy = model._createdBy,
                ModifiedDate = model._modifiedDate,
                ModifiedBy = model._modifiedBy
            };
        }

        public static List<Shared.Models.CustomerDomain.Customer>
        ToEntityList(List<CustomerModel> modelsList)
        {
            if (modelsList == null)
            {
                return null;
            }

            return modelsList
                .Select(entity =>
                    (Shared.Models.CustomerDomain.Customer) entity)
                .ToList();
        }
    }
}
