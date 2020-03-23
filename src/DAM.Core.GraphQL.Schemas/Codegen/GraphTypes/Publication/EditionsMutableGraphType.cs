//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.PublicationDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.PublicationDomain
{
    public class EditionsMutableGraphType : ObjectGraphType<EditionsModel>
    {
        public EditionsMutableGraphType()
        {
            Name = "PublicationMutable_Editions";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Name, nullable: true);
            Field(o => o.Languages,
            true,
            typeof (ListGraphType<LanguagesMutableGraphType>))
                .Resolve(context => context.Source.Languages);
        }
    }
}
