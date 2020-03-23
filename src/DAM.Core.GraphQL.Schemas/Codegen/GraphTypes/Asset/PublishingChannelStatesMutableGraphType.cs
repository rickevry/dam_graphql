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
    PublishingChannelStatesMutableGraphType
    : ObjectGraphType<PublishingChannelStatesModel>
    {
        public PublishingChannelStatesMutableGraphType()
        {
            Name = "AssetMutable_PublishingChannelStates";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Channel, nullable: true);
            Field(o => o.State, nullable: true);
        }
    }
}
