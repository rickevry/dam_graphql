//
//  This file was automatically generated and should not be edited.
//  2020-02-28T09:54:22.689Z
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.Asset;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    public class DocumentStateGraphType : ObjectGraphType<DocumentStateModel>
    {
        public DocumentStateGraphType()
        {
            Name = "Asset_DocumentState";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.State, nullable: true);
            Field(o => o.IsPublished, nullable: true);
            Field(o => o.PublishingChannelStates,
            true,
            typeof (ListGraphType<PublishingChannelStatesGraphType>))
                .Resolve(context => context.Source.PublishingChannelStates);
        }
    }
}
