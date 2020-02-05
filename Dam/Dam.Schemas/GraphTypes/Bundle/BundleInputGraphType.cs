//
//  This file was automatically generated and should not be edited.
//  2020-02-05T21:54:55.751Z
//
using System;
using System.Collections.Generic;
using Dam.Schemas.Entities.Bundle;
using GraphQL.Types;

namespace Dam.Schemas.GraphTypes.Bundle
{
    public class BundleInputGraphType : InputObjectGraphType<BundleEntity>
    {
        public BundleInputGraphType()
        {
            Name = "BundleInput";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.BundleId, nullable: true);
            Field(o => o.Version, true, typeof (VersionInputGraphType))
                .Resolve(context => context.Source.Version);
            Field(o => o.BundleTitle, nullable: true);
            Field(o => o.BundleDescription, nullable: true);
            Field(o => o.LanguagesInAssets, nullable: true);
            Field(o => o.Attachment,
            true,
            typeof (ListGraphType<AttachmentInputGraphType>))
                .Resolve(context => context.Source.Attachment);
            Field(o => o.Icon, nullable: true);
            Field(o => o.Country, nullable: true);
            Field(o => o.Collections, nullable: true);
        }
    }
}
