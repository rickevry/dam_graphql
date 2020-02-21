//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.569Z
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
            Field(o => o.PublicationId, nullable: true);
            Field(o => o.AssetId, nullable: true);
            Field(o => o.PublishId, nullable: true);
            Field(o => o.PublishingUnit, nullable: true);
            Field(o => o.DocumentAttributes,
            true,
            typeof (DocumentAttributesGraphType))
                .Resolve(context => context.Source.DocumentAttributes);
            Field(o => o.AssetType, true, typeof (AssetTypeGraphType))
                .Resolve(context => context.Source.AssetType);
            Field(o => o.Title, nullable: true);
            Field(o => o.AssetSource, nullable: true);
            Field(o => o.LanguageCode, nullable: true);
            Field(o => o.FileName, nullable: true);
            Field(o => o.FileModifiedDate, nullable: true);
            Field(o => o.CopyrightOwner, nullable: true);
            Field(o => o.Categories, nullable: true);
            Field(o => o.InternalDescription, nullable: true);
            Field(o => o.MetadataModifiedDate, nullable: true);
            Field(o => o.CheckedOutBy, nullable: true);
            Field(o => o.CopyrightDescription, nullable: true);
            Field(o => o.IsCheckedOut, nullable: true);
            Field(o => o.ExternalDescription, nullable: true);
            Field(o => o.Renditions,
            true,
            typeof (ListGraphType<RenditionsGraphType>))
                .Resolve(context => context.Source.Renditions);
            Field(o => o.RepublishedDate, nullable: true);
            Field(o => o.CopyrightExpiryDate, nullable: true);
            Field(o => o.PublishedDate, nullable: true);
            Field(o => o.AssetRole, nullable: true);
            Field(o => o.Version, true, typeof (VersionGraphType))
                .Resolve(context => context.Source.Version);
            Field(o => o.PublishEnabled, nullable: true);
            Field(o => o.PublishingChannelStates,
            true,
            typeof (ListGraphType<PublishingChannelStatesGraphType>))
                .Resolve(context => context.Source.PublishingChannelStates);
            Field(o => o.ExpiryDate, nullable: true);
            Field(o => o.PublicationDesignation, nullable: true);
            Field(o => o.AssetSites,
            true,
            typeof (ListGraphType<AssetSitesGraphType>))
                .Resolve(context => context.Source.AssetSites);
            Field(o => o.ProductDesignation,
            true,
            typeof (ListGraphType<ProductDesignationGraphType>))
                .Resolve(context => context.Source.ProductDesignation);
            Field(o => o.Rights, true, typeof (RightsGraphType))
                .Resolve(context => context.Source.Rights);
            Field(o => o.State, nullable: true);
        }
    }
}
