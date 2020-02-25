//
//  This file was automatically generated and should not be edited.
//  2020-02-25T11:04:53.526Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    public class DocumentInfoGraphType : ObjectGraphType<DocumentInfoModel>
    {
        public DocumentInfoGraphType()
        {
            Name = "Asset_DocumentInfo";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.InternalDescription, nullable: true);
            Field(o => o.ExternalDescription, nullable: true);
            Field(o => o.AssetType, nullable: true);
            Field(o => o.Taxonomy, nullable: true);
            Field(o => o.LanguageCode, nullable: true);
            Field(o => o.Title, nullable: true);
            Field(o => o.FolderId, nullable: true);
            Field(o => o.AssetRole, nullable: true);
            Field(o => o.PublicationDesignation, nullable: true);
            Field(o => o.SecurityClass, nullable: true);
            Field(o => o.TridionRestricted, nullable: true);
            Field(o => o.CreatedDate, nullable: true);
            Field(o => o.CreatedBy, nullable: true);
            Field(o => o.ModifiedDate, nullable: true);
            Field(o => o.ModifiedBy, nullable: true);
        }
    }
}
