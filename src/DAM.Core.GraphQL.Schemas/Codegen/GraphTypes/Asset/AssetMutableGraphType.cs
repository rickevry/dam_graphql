//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.AssetDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.AssetDomain
{
    public class AssetMutableGraphType : ObjectGraphType<AssetModel>
    {
        public AssetMutableGraphType()
        {
            Name = "AssetMutable_Asset";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.DocumentState,
            true,
            typeof (DocumentStateMutableGraphType))
                .Resolve(context => context.Source.DocumentState);
            Field(o => o.Id, nullable: true);
            Field(o => o.Copyright, true, typeof (CopyrightMutableGraphType))
                .Resolve(context => context.Source.Copyright);
            Field(o => o.AssetId, nullable: true);
            Field(o => o.PublicationId, nullable: true);
            Field(o => o.DocumentInfo,
            true,
            typeof (DocumentInfoMutableGraphType))
                .Resolve(context => context.Source.DocumentInfo);
            Field(o => o.PublishingUnitId, nullable: true);
            Field(o => o.DocumentAttributes,
            true,
            typeof (DocumentAttributesMutableGraphType))
                .Resolve(context => context.Source.DocumentAttributes);
            Field(o => o.ReleaseForm,
            true,
            typeof (ReleaseFormMutableGraphType))
                .Resolve(context => context.Source.ReleaseForm);
            Field(o => o.ProductInfo,
            true,
            typeof (ProductInfoMutableGraphType))
                .Resolve(context => context.Source.ProductInfo);
            Field(o => o.Version, true, typeof (VersionMutableGraphType))
                .Resolve(context => context.Source.Version);
            Field(o => o.CreatedDate, nullable: true);
            Field(o => o.ModifiedDate, nullable: true);
            Field(o => o.CreatedBy, nullable: true);
            Field(o => o.ModifiedBy, nullable: true);
            Field(o => o.TridionRestricted, nullable: true);
            Field(o => o.Renditions,
            true,
            typeof (ListGraphType<RenditionsMutableGraphType>))
                .Resolve(context => context.Source.Renditions);
        }
    }
}
