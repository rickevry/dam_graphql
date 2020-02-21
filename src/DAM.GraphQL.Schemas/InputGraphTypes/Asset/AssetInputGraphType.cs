//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:17.285Z
//
using System;
using System.Collections.Generic;
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
            Field(o => o.PublicationId, nullable: true);
            Field(o => o.AssetId, nullable: true);
            Field(o => o.PublishId, nullable: true);
            Field(o => o.PublishingUnit, nullable: true);
            Field(o => o.DocumentAttributes,
            true,
            typeof (DocumentAttributesInputGraphType))
                .Resolve(context => context.Source.DocumentAttributes);
            Field(o => o.AssetType, nullable: true);
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
            typeof (ListGraphType<RenditionsInputGraphType>))
                .Resolve(context => context.Source.Renditions);
            Field(o => o.RepublishedDate, nullable: true);
            Field(o => o.CopyrightExpiryDate, nullable: true);
            Field(o => o.PublishedDate, nullable: true);
            Field(o => o.AssetRole, nullable: true);
            Field(o => o.Version, true, typeof (VersionInputGraphType))
                .Resolve(context => context.Source.Version);
            Field(o => o.PublishEnabled, nullable: true);
            Field(o => o.PublishingChannelStates,
            true,
            typeof (ListGraphType<PublishingChannelStatesInputGraphType>))
                .Resolve(context => context.Source.PublishingChannelStates);
            Field(o => o.ExpiryDate, nullable: true);
            Field(o => o.AssetSites,
            true,
            typeof (ListGraphType<AssetSitesInputGraphType>))
                .Resolve(context => context.Source.AssetSites);
            Field(o => o.ProductDesignation,
            true,
            typeof (ListGraphType<ProductDesignationInputGraphType>))
                .Resolve(context => context.Source.ProductDesignation);
            Field(o => o.Rights, true, typeof (RightsInputGraphType))
                .Resolve(context => context.Source.Rights);
            Field(o => o.PublicationDesignation, nullable: true);
            Field(o => o.Authors, nullable: true);
            Field(o => o.State, nullable: true);
        }
    }
}
