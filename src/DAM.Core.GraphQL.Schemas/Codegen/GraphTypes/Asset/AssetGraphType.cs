//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:58.971Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Asset
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
            Field(o => o.DocumentState, true, typeof (DocumentStateGraphType))
                .Resolve(context => context.Source.DocumentState);
            Field(o => o.Id, nullable: true);
            Field(o => o.AssetId, nullable: true);
            Field(o => o.PublicationId, nullable: true);
            Field(o => o.DocumentAttributes,
            true,
            typeof (DocumentAttributesGraphType))
                .Resolve(context => context.Source.DocumentAttributes);
            Field(o => o.DocumentInfo, true, typeof (DocumentInfoGraphType))
                .Resolve(context => context.Source.DocumentInfo);
            Field(o => o.PublishId, nullable: true);
            Field(o => o.PublishingUnitId, nullable: true);
            Field(o => o.ProductDesignation,
            true,
            typeof (ListGraphType<ProductDesignationGraphType>))
                .Resolve(context => context.Source.ProductDesignation);
            Field(o => o.Version, true, typeof (VersionGraphType))
                .Resolve(context => context.Source.Version);
            Field(o => o.Rights, true, typeof (RightsGraphType))
                .Resolve(context => context.Source.Rights);
            Field(o => o.Renditions,
            true,
            typeof (ListGraphType<RenditionsGraphType>))
                .Resolve(context => context.Source.Renditions);
        }
    }
}
