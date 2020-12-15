//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.GraphQL.Schemas.TermsetDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.AssetDomain
{
    public class TermsetMutableGraphType : ObjectGraphType<TermsetModel>
    {
        public TermsetMutableGraphType()
        {
            Name = "TermsetMutable_Termset";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Id, nullable: true);
            Field(o => o.Title, nullable: true);
            Field(o => o.Terms,
            true,
            typeof (ListGraphType<TermsetMutableGraphType>))
                .Resolve(context => context.Source.Terms);
        }
    }
}
