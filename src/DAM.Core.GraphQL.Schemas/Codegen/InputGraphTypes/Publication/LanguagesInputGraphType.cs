//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:57.624Z
//
using System;
using System.Collections.Generic;
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
