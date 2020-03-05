//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.Asset;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    public class
    DocumentStateInputGraphType
    : InputObjectGraphType<DocumentStateModel>
    {
        public DocumentStateInputGraphType()
        {
            Name = "Asset_DocumentStateInput";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.State, nullable: true);
            Field(o => o.IsPublished, nullable: true);
            Field(o => o.PublishingChannelStates,
            true,
            typeof (ListGraphType<PublishingChannelStatesInputGraphType>))
                .Resolve(context => context.Source.PublishingChannelStates);
        }
    }
}
