//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.PublicationDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.PublicationDomain
{
    public class PublicationGraphType : ObjectGraphType<PublicationModel>
    {
        public PublicationGraphType()
        {
            Name = "Publication_Publication";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Id, nullable: true);
            Field(o => o.PublicationName, nullable: true);
            Field(o => o.Editions,
            true,
            typeof (ListGraphType<EditionsGraphType>))
                .Resolve(context => context.Source.Editions);
            Field(o => o.Assets, true, typeof (ListGraphType<AssetsGraphType>))
                .Resolve(context => context.Source.Assets);
            Field(o => o.PublicationId, nullable: true);
            Field(o => o.AssetType, true, typeof (AssetTypeGraphType))
                .Resolve(context => context.Source.AssetType);
            Field(o => o.InternalDescription, nullable: true);
            Field(o => o.ExternalDescription, nullable: true);
            Field(o => o.PublishingUnit, nullable: true);
            Field(o => o.CreatedDate, nullable: true);
            Field(o => o.CreatedBy, nullable: true);
            Field(o => o.ModifiedDate, nullable: true);
            Field(o => o.ModifiedBy, nullable: true);
        }
    }
}
