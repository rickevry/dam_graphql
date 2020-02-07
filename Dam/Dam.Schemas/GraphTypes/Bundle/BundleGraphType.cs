//
//  This file was automatically generated and should not be edited.
//  2020-02-07T10:08:59.194Z
//
using System;
using System.Collections.Generic;
using Dam.Schemas.Entities.Bundle;
using GraphQL.Types;

namespace Dam.Schemas.GraphTypes.Bundle
{
    public class BundleGraphType : ObjectGraphType<BundleEntity>
    {
        public BundleGraphType()
        {
            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.BundleId, nullable: true);
            Field(o => o.Version, true, typeof (VersionGraphType))
                .Resolve(context => context.Source.Version);
            Field(o => o.BundleTitle, nullable: true);
            Field(o => o.BundleDescription, nullable: true);
            Field(o => o.LanguagesInAssets, nullable: true);
            Field(o => o.Attachment,
            true,
            typeof (ListGraphType<AttachmentGraphType>))
                .Resolve(context => context.Source.Attachment);
            Field(o => o.Icon, nullable: true);
            Field(o => o.Country, nullable: true);
            Field(o => o.Collections, nullable: true);
        }
    }
}
