//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.AssetDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.AssetDomain
{
    public class LanguagesMutableGraphType : ObjectGraphType<LanguagesModel>
    {
        public LanguagesMutableGraphType()
        {
            Name = "AssetMutable_Languages";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.IsoCode, nullable: true);
            Field(o => o.Description, nullable: true);
        }
    }
}
