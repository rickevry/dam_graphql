//
//  This file was automatically generated and should not be edited.
//  2020-02-12T14:09:31.923Z
//
using System;
using System.Collections.Generic;
using DAM.Core.DataModels.Bundle;
using GraphQL.Types;

namespace DAM.GraphQL.Schemas.Bundle
{
    public class BundleGraphType : ObjectGraphType<BundleModel>
    {
        public BundleGraphType()
        {
            Name = "Bundle_Bundle";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.BundleId, nullable: true);
            Field(o => o.Version, true, typeof (VersionGraphType))
                .Resolve(context => context.Source.Version);
            Field(o => o.BundleTitle, nullable: true);
            Field(o => o.BundleDescription, nullable: true);
            Field(o => o.Invoice, true, typeof (FileInfoGraphType))
                .Resolve(context => context.Source.Invoice);
            Field(o => o.LanguagesInAssets, nullable: true);
            Field(o => o.Icon, nullable: true);
            Field(o => o.Attachments,
            true,
            typeof (ListGraphType<FileInfoGraphType>))
                .Resolve(context => context.Source.Attachments);
            Field(o => o.Country, nullable: true);
            Field(o => o.Collections, nullable: true);
        }
    }
}
