//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:57.624Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Publication
{
    public class LanguagesGraphType : ObjectGraphType<LanguagesModel>
    {
        public LanguagesGraphType()
        {
            Name = "Publication_Languages";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Language, true, typeof (LanguageGraphType))
                .Resolve(context => context.Source.Language);
            Field(o => o.Assets, true, typeof (ListGraphType<AssetsGraphType>))
                .Resolve(context => context.Source.Assets);
        }
    }
}
