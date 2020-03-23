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
    DocumentAttributesInputGraphType
    : InputObjectGraphType<DocumentAttributesModel>
    {
        public DocumentAttributesInputGraphType()
        {
            Name = "Asset_DocumentAttributesInput";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.FileModifiedDate, nullable: true);
            Field(o => o.CheckedOutBy, nullable: true);
            Field(o => o.IsCheckedOut, nullable: true);
            Field(o => o.RepublishedDate, nullable: true);
            Field(o => o.PublishedDate, nullable: true);
            Field(o => o.Checksum, nullable: true);
            Field(o => o.FileSize, nullable: true);
            Field(o => o.MetadataModifiedDate, nullable: true);
            Field(o => o.FileName, nullable: true);
            Field(o => o.MimeType, nullable: true);
            Field(o => o.Resolution, true, typeof (ResolutionInputGraphType))
                .Resolve(context => context.Source.Resolution);
        }
    }
}
