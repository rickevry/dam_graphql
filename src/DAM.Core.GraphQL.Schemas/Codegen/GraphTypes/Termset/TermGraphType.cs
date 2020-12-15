//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.TermsetDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.TermsetDomain
{
    public class TermGraphType : ObjectGraphType<DAM.Core.Shared.Models.TermsetDomain.Term>
    {
        public TermGraphType()
        {
            Name = "Termset_Term";
            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Id, nullable: true);
            Field(o => o.Pid, nullable: true);
            Field(o => o.Title, nullable: true);
        }
    }
}
