//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.438Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.GraphQL.Schemas.Asset
{
    public class
    PublishingChannelStatesGraphType
    : ObjectGraphType<PublishingChannelStatesModel>
    {
        public PublishingChannelStatesGraphType()
        {
            Name = "Asset_PublishingChannelStates";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Channel, nullable: true);
            Field(o => o.State, nullable: true);
        }
    }
}
