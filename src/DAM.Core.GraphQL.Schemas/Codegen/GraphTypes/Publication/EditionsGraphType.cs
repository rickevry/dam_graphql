//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:57.624Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Publication
{
    public class EditionsGraphType : ObjectGraphType<EditionsModel>
    {
        public EditionsGraphType()
        {
            Name = "Publication_Editions";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Name, nullable: true);
            Field(o => o.Languages,
            true,
            typeof (ListGraphType<LanguagesGraphType>))
                .Resolve(context => context.Source.Languages);
        }
    }
}
