//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:58.249Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Asset
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
        }
    }
}