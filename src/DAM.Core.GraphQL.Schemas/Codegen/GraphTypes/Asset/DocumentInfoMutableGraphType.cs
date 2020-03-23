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
    DocumentInfoMutableGraphType
    : ObjectGraphType<DocumentInfoModel>
    {
        public DocumentInfoMutableGraphType()
        {
            Name = "AssetMutable_DocumentInfo";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.InternalDescription, nullable: true);
            Field(o => o.ExternalDescription, nullable: true);
            Field(o => o.AssetType, nullable: true);
            Field(o => o.Taxonomy, nullable: true);
            Field(o => o.Languages,
            true,
            typeof (ListGraphType<LanguagesMutableGraphType>))
                .Resolve(context => context.Source.Languages);
            Field(o => o.Title, nullable: true);
            Field(o => o.FolderId, nullable: true);
            Field(o => o.AssetRole, nullable: true);
            Field(o => o.PublicationDesignation, nullable: true);
            Field(o => o.SecurityClass, nullable: true);
            Field(o => o.TridionRestricted, nullable: true);
        }
    }
}
