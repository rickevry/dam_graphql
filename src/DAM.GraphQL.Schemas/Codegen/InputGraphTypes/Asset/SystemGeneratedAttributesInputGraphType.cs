//
//  This file was automatically generated and should not be edited.
//  2020-02-20T16:00:25.581Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.GraphQL.Schemas.Asset
{
    public class
    SystemGeneratedAttributesInputGraphType
    : InputObjectGraphType<SystemGeneratedAttributesModel>
    {
        public SystemGeneratedAttributesInputGraphType()
        {
            Name = "Asset_SystemGeneratedAttributesInput";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Size, nullable: true);
            Field(o => o.Checksum, nullable: true);
            Field(o => o.ModifiedDate, nullable: true);
            Field(o => o.RepublishedDate, nullable: true);
            Field(o => o.Renditions,
            true,
            typeof (ListGraphType<RenditionsInputGraphType>))
                .Resolve(context => context.Source.Renditions);
            Field(o => o.PublishedDate, nullable: true);
            Field(o => o.IsCheckedOut, nullable: true);
            Field(o => o.CheckedOutBy, nullable: true);
        }
    }
}
