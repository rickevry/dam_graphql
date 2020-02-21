//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.158Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.GraphQL.Schemas.Publication
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
            Field(o => o.CreationDate, nullable: true);
            Field(o => o.ModifyDate, nullable: true);
        }
    }
}
