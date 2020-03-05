//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.Collection;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Collection
{
    public class CollectionGraphType : ObjectGraphType<CollectionModel>
    {
        public CollectionGraphType()
        {
            Name = "Collection_Collection";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Id, nullable: true);
            Field(o => o.CollectionTitle, nullable: true);
            Field(o => o.PublicationDate, nullable: true);
            Field(o => o.CollectionDescription, nullable: true);
            Field(o => o.CollectionType, nullable: true);
            Field(o => o.CollectionVisibility, nullable: true);
            Field(o => o.Assets, nullable: true);
            Field(o => o.ShowOnStartPage, nullable: true);
            Field(o => o.CoverAssetId, nullable: true);
            Field(o => o.CreatedDate, nullable: true);
            Field(o => o.CreatedBy, nullable: true);
            Field(o => o.isNewCollection, nullable: true);
            Field(o => o.ModifiedDate, nullable: true);
            Field(o => o.ModifiedBy, nullable: true);
        }
    }
}
