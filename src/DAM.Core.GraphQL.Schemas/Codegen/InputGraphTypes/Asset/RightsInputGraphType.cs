//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:58.904Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    public class RightsInputGraphType : InputObjectGraphType<RightsModel>
    {
        public RightsInputGraphType()
        {
            Name = "Asset_RightsInput";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.SecurityClass, nullable: true);
            Field(o => o.RightsManaged, nullable: true);
            Field(o => o.TridionRestricted, nullable: true);
            Field(o => o.RightsManagedDescription, nullable: true);
        }
    }
}
