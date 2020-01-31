//
//  This file was automatically generated and should not be edited.
//  2020-01-31T20:54:44.812Z
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
            Field(o => o.BundleId);
            Field(o => o.Version, true, typeof (VersionGraphType))
                .Resolve(context => context.Source.Version);
            Field(o => o.BundleTitle);
            Field(o => o.BundleDescription);
            Field(o => o.LanguagesInAssets);
            Field(o => o.Attachment,
            true,
            typeof (ListGraphType<AttachmentGraphType>))
                .Resolve(context => context.Source.Attachment);
            Field(o => o.Icon);
            Field(o => o.Country);
            Field(o => o.Collections);
        }
    }
}
