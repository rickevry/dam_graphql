//
//  This file was automatically generated and should not be edited.
//  2020-02-25T11:04:53.948Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Sample
{
    public class SampleInputGraphType : InputObjectGraphType<SampleModel>
    {
        public SampleInputGraphType()
        {
            Name = "Sample_SampleInput";

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
