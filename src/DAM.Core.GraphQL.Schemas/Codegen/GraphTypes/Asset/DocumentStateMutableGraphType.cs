//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.AssetDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.AssetDomain
{
    public class
    DocumentStateMutableGraphType
    : ObjectGraphType<DocumentStateModel>
    {
        public DocumentStateMutableGraphType()
        {
            Name = "AssetMutable_DocumentState";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.State, nullable: true);
            Field(o => o.IsPublished, nullable: true);
            Field(o => o.PublishingChannelStates,
            true,
            typeof (ListGraphType<PublishingChannelStatesMutableGraphType>))
                .Resolve(context => context.Source.PublishingChannelStates);
        }
    }
}
