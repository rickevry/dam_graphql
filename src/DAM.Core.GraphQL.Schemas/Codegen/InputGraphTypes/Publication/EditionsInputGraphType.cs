//
//  This file was automatically generated and should not be edited.
//  2020-02-25T11:04:52.979Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Publication
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
