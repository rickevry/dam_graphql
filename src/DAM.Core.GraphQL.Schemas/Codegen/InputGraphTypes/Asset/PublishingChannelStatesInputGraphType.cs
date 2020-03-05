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
