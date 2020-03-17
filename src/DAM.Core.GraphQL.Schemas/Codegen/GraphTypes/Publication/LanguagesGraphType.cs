//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.PublicationDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.PublicationDomain
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
