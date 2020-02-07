//
//  This file was automatically generated and should not be edited.
//  2020-02-07T10:08:59.153Z
//
using System;
using System.Collections.Generic;
using Dam.Schemas.Entities.Bundle;
using GraphQL.Types;

namespace Dam.Schemas.GraphTypes.Bundle
{
    public class VersionInputGraphType : InputObjectGraphType<VersionEntity>
    {
        public VersionInputGraphType()
        {
            Name = "VersionInput";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Major, nullable: true);
            Field(o => o.Minor, nullable: true);
        }
    }
}
