//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.Publication;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Publication
{
    public class LanguagesInputGraphType : InputObjectGraphType<LanguagesModel>
    {
        public LanguagesInputGraphType()
        {
            Name = "Publication_LanguagesInput";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Language, true, typeof (LanguageInputGraphType))
                .Resolve(context => context.Source.Language);
            Field(o => o.Assets,
            true,
            typeof (ListGraphType<AssetsInputGraphType>))
                .Resolve(context => context.Source.Assets);
        }
    }
}
