//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.Publication;
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
