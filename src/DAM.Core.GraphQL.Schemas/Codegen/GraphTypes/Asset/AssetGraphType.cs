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
    AssetGraphType
    : ObjectGraphType<DAM.Core.Shared.Models.AssetDomain.Asset>
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
            Field(o => o.Copyright, true, typeof (CopyrightGraphType))
                .Resolve(context => context.Source.Copyright);
            Field(o => o.AssetId, nullable: true);
            Field(o => o.PublicationId, nullable: true);
            Field(o => o.DocumentInfo, true, typeof (DocumentInfoGraphType))
                .Resolve(context => context.Source.DocumentInfo);
            Field(o => o.PublishingUnitId, nullable: true);
            Field(o => o.DocumentAttributes,
            true,
            typeof (DocumentAttributesGraphType))
                .Resolve(context => context.Source.DocumentAttributes);
            Field(o => o.ReleaseForm, true, typeof (ReleaseFormGraphType))
                .Resolve(context => context.Source.ReleaseForm);
            Field(o => o.ProductInfo, true, typeof (ProductInfoGraphType))
                .Resolve(context => context.Source.ProductInfo);
            Field(o => o.Version, true, typeof (VersionGraphType))
                .Resolve(context => context.Source.Version);
            Field(o => o.CreatedDate, nullable: true);
            Field(o => o.ModifiedDate, nullable: true);
            Field(o => o.CreatedBy, nullable: true);
            Field(o => o.ModifiedBy, nullable: true);
            Field(o => o.TridionRestricted, nullable: true);
            Field(o => o.Renditions,
            true,
            typeof (ListGraphType<RenditionsGraphType>))
                .Resolve(context => context.Source.Renditions);
        }
    }
}
