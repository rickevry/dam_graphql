//
//  This file was automatically generated and should not be edited.
//  2020-02-21T10:21:07.297Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.GraphQL.Schemas.Asset
{
    public class
    DocumentAttributesGraphType
    : ObjectGraphType<DocumentAttributesModel>
    {
        public DocumentAttributesGraphType()
        {
            Name = "Asset_DocumentAttributes";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.DocumentContent, nullable: true);
            Field(o => o.Size, nullable: true);
            Field(o => o.Checksum, nullable: true);
        }
    }
}
