//
//  This file was automatically generated and should not be edited.
//  2020-02-28T09:54:23.242Z
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.Asset;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Asset
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
            Field(o => o.DocumentState,
            true,
            typeof (DocumentStateInputGraphType))
                .Resolve(context => context.Source.DocumentState);
            Field(o => o.Id, nullable: true);
            Field(o => o.AssetId, nullable: true);
            Field(o => o.PublicationId, nullable: true);
            Field(o => o.DocumentAttributes,
            true,
            typeof (DocumentAttributesInputGraphType))
                .Resolve(context => context.Source.DocumentAttributes);
            Field(o => o.PublishId, nullable: true);
            Field(o => o.DocumentInfo,
            true,
            typeof (DocumentInfoInputGraphType))
                .Resolve(context => context.Source.DocumentInfo);
            Field(o => o.PublishingUnitId, nullable: true);
            Field(o => o.ProductDesignation,
            true,
            typeof (ListGraphType<ProductDesignationInputGraphType>))
                .Resolve(context => context.Source.ProductDesignation);
            Field(o => o.Version, true, typeof (VersionInputGraphType))
                .Resolve(context => context.Source.Version);
            Field(o => o.Renditions,
            true,
            typeof (ListGraphType<RenditionsInputGraphType>))
                .Resolve(context => context.Source.Renditions);
            Field(o => o.CreatedDate, nullable: true);
            Field(o => o.ModifiedDate, nullable: true);
            Field(o => o.CreatedBy, nullable: true);
            Field(o => o.ModifiedBy, nullable: true);
        }
    }
}
