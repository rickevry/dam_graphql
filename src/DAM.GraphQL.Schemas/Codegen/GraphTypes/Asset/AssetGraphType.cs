//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.968Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.GraphQL.Schemas.Asset
{
    public class AssetGraphType : ObjectGraphType<AssetModel>
    {
        public AssetGraphType()
        {
            Name = "Asset_Asset";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Id, nullable: true);
            Field(o => o.AssetId, nullable: true);
            Field(o => o.PublishId, nullable: true);
            Field(o => o.PublishingUnit, nullable: true);
            Field(o => o.PublicationID, nullable: true);
            Field(o => o.AssetType, true, typeof (AssetTypeGraphType))
                .Resolve(context => context.Source.AssetType);
            Field(o => o.AssetTitle, nullable: true);
            Field(o => o.AssetSource, nullable: true);
            Field(o => o.LanguageCode, nullable: true);
            Field(o => o.AssetFileName, nullable: true);
            Field(o => o.SystemGeneratedAttributes,
            true,
            typeof (SystemGeneratedAttributesGraphType))
                .Resolve(context => context.Source.SystemGeneratedAttributes);
            Field(o => o.CopyrightOwner, nullable: true);
            Field(o => o.Industry, nullable: true);
            Field(o => o.InternalDescription, nullable: true);
            Field(o => o.CopyrightDescription, nullable: true);
            Field(o => o.Products, nullable: true);
            Field(o => o.ExternalDescription, nullable: true);
            Field(o => o.CopyrightExpiryDate, nullable: true);
            Field(o => o.Services, nullable: true);
            Field(o => o.OriginalFileName, nullable: true);
            Field(o => o.Version, true, typeof (VersionGraphType))
                .Resolve(context => context.Source.Version);
            Field(o => o.PublishEnabled, nullable: true);
            Field(o => o.Corporate,
            true,
            typeof (ListGraphType<CorporateGraphType>))
                .Resolve(context => context.Source.Corporate);
            Field(o => o.PublishingChannelStates,
            true,
            typeof (ListGraphType<PublishingChannelStatesGraphType>))
                .Resolve(context => context.Source.PublishingChannelStates);
            Field(o => o.ExpiryDate, nullable: true);
            Field(o => o.AssetRole, nullable: true);
            Field(o => o.PublicationDesignation, nullable: true);
            Field(o => o.CustomerChannel,
            true,
            typeof (ListGraphType<CustomerChannelGraphType>))
                .Resolve(context => context.Source.CustomerChannel);
            Field(o => o.AssetSites,
            true,
            typeof (ListGraphType<AssetSitesGraphType>))
                .Resolve(context => context.Source.AssetSites);
            Field(o => o.ProductDesignation,
            true,
            typeof (ListGraphType<ProductDesignationGraphType>))
                .Resolve(context => context.Source.ProductDesignation);
            Field(o => o.State, nullable: true);
            Field(o => o.Rights, true, typeof (RightsGraphType))
                .Resolve(context => context.Source.Rights);
        }
    }
}