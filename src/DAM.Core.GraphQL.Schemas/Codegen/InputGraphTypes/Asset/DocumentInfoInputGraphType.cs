//
//  This file was automatically generated and should not be edited.
//  2020-02-28T09:54:23.009Z
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.Asset;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Asset
{
    public class
    DocumentInfoInputGraphType
    : InputObjectGraphType<DocumentInfoModel>
    {
        public DocumentInfoInputGraphType()
        {
            Name = "Asset_DocumentInfoInput";

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
        }
    }
}
