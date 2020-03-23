//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.PublicationDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.PublicationDomain
{
    public class LanguagesMutableGraphType : ObjectGraphType<LanguagesModel>
    {
        public LanguagesMutableGraphType()
        {
            Name = "PublicationMutable_Languages";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Language, true, typeof (LanguageMutableGraphType))
                .Resolve(context => context.Source.Language);
            Field(o => o.Assets,
            true,
            typeof (ListGraphType<AssetsMutableGraphType>))
                .Resolve(context => context.Source.Assets);
        }
    }
}
