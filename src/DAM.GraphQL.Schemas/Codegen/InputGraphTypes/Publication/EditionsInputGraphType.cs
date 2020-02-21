//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.071Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.GraphQL.Schemas.Publication
{
    public class EditionsInputGraphType : InputObjectGraphType<EditionsModel>
    {
        public EditionsInputGraphType()
        {
            Name = "Publication_EditionsInput";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Name, nullable: true);
            Field(o => o.Languages,
            true,
            typeof (ListGraphType<LanguagesInputGraphType>))
                .Resolve(context => context.Source.Languages);
        }
    }
}
