//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.Sample;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Sample
{
    public class SampleGraphType : ObjectGraphType<SampleModel>
    {
        public SampleGraphType()
        {
            Name = "Sample_Sample";

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
