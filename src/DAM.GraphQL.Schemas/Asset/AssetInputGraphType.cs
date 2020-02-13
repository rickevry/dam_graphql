//
//  This file was automatically generated and should not be edited.
//  2020-02-12T14:09:32.167Z
//
using System;
using System.Collections.Generic;
using DAM.Core.DataModels.Asset;
using GraphQL.Types;

namespace DAM.GraphQL.Schemas.Asset
{
    public class AssetInputGraphType : InputObjectGraphType<AssetModel>
    {
        public AssetInputGraphType()
        {
            Name = "Asset_AssetInput";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Id, nullable: true);
            Field(o => o.PublishId, nullable: true);
            Field(o => o.PublishingUnit, nullable: true);
            Field(o => o.PublicationID, nullable: true);
            Field(o => o.AssetType, nullable: true);
            Field(o => o.AssetTitle, nullable: true);
            Field(o => o.AssetSource, nullable: true);
            Field(o => o.LanguageCode, nullable: true);
            Field(o => o.AssetFileName, nullable: true);
            Field(o => o.CopyrightOwner, nullable: true);
            Field(o => o.Industry, nullable: true);
            Field(o => o.InternalDescription, nullable: true);
            Field(o => o.CopyrightDescription, nullable: true);
            Field(o => o.Products, nullable: true);
            Field(o => o.ExternalDescription, nullable: true);
            Field(o => o.CopyrightExpiryDate, nullable: true);
            Field(o => o.Services, nullable: true);
            Field(o => o.Version, true, typeof (VersionInputGraphType))
                .Resolve(context => context.Source.Version);
            Field(o => o.PublishEnabled, nullable: true);
            Field(o => o.Corporate, nullable: true);
            Field(o => o.PublishingChannelStates, nullable: true);
            Field(o => o.ExpiryDate, nullable: true);
            Field(o => o.AssetRole, nullable: true);
            Field(o => o.PublicationDesignation, nullable: true);
            Field(o => o.CustomerChannel, nullable: true);
            Field(o => o.AssetSites, nullable: true);
            Field(o => o.ProductDesignation,
            true,
            typeof (ListGraphType<ProductDesignationInputGraphType>))
                .Resolve(context => context.Source.ProductDesignation);
            Field(o => o.confirmedBy, nullable: true);
            Field(o => o.State, nullable: true);
            Field(o => o.Rights, true, typeof (RightsInputGraphType))
                .Resolve(context => context.Source.Rights);
        }
    }
}
