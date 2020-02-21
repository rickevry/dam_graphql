//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.699Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.GraphQL.Schemas.Asset
{
    public class
    PublishingChannelStatesInputGraphType
    : InputObjectGraphType<PublishingChannelStatesModel>
    {
        public PublishingChannelStatesInputGraphType()
        {
            Name = "Asset_PublishingChannelStatesInput";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Channel, nullable: true);
            Field(o => o.State, nullable: true);
        }
    }
}