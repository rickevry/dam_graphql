//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.CustomerDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.CustomerDomain
{
    public class CustomerMutableGraphType : ObjectGraphType<CustomerModel>
    {
        public CustomerMutableGraphType()
        {
            Name = "CustomerMutable_Customer";

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
