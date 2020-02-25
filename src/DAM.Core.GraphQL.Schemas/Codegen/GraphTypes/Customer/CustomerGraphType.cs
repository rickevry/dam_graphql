//
//  This file was automatically generated and should not be edited.
//  2020-02-25T11:04:52.807Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Customer
{
    public class CustomerGraphType : ObjectGraphType<CustomerModel>
    {
        public CustomerGraphType()
        {
            Name = "Customer_Customer";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Id, nullable: true);
            Field(o => o.CreatedDate, nullable: true);
            Field(o => o.CreatedBy, nullable: true);
            Field(o => o.ModifiedDate, nullable: true);
            Field(o => o.ModifiedBy, nullable: true);
        }
    }
}
