//
//  This file was automatically generated and should not be edited.
//  2020-02-12T14:09:32.167Z
//
using System;
using System.Collections.Generic;
using DAM.Core.DataModels.Asset;
using GraphQL.Types;

namespace DAM.GraphQL.Schemas.Asset
{
    public class RightsGraphType : ObjectGraphType<RightsModel>
    {
        public RightsGraphType()
        {
            Name = "Asset_Rights";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.SecurityClass, nullable: true);
            Field(o => o.RightsManaged, nullable: true);
            Field(o => o.RightsManagedDescription, nullable: true);
            Field(o => o.TridionRestricted, nullable: true);
        }
    }
}
