//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.AssetDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.AssetDomain
{
    public class
    ReleaseFormInputGraphType
    : InputObjectGraphType<ReleaseFormModel>
    {
        public ReleaseFormInputGraphType()
        {
            Name = "Asset_ReleaseFormInput";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.modelReleaseForms, nullable: true);
            Field(o => o.generalReleaseForms, nullable: true);
        }
    }
}
