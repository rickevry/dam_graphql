//
//  This file was automatically generated and should not be edited.
//  2020-01-31T20:54:44.753Z
//
using System;
using System.Collections.Generic;
using Dam.Schemas.Entities.Bundle;
using GraphQL.Types;

namespace Dam.Schemas.GraphTypes.Bundle
{
    public class VersionGraphType : ObjectGraphType<VersionEntity>
    {
        public VersionGraphType()
        {
            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Major);
            Field(o => o.Minor);
        }
    }
}
