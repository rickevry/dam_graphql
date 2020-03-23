//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.SampleDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.SampleDomain
{
    public class SampleMutableGraphType : ObjectGraphType<SampleModel>
    {
        public SampleMutableGraphType()
        {
            Name = "SampleMutable_Sample";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.CreatedDate, nullable: true);
            Field(o => o.CreatedBy, nullable: true);
            Field(o => o.ModifiedDate, nullable: true);
            Field(o => o.ModifiedBy, nullable: true);
        }
    }
}
