//
//  This file was automatically generated and should not be edited.
//  2020-02-21T11:11:16.785Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.GraphQL.Schemas.Collection
{
    public class
    CollectionInputGraphType
    : InputObjectGraphType<CollectionModel>
    {
        public CollectionInputGraphType()
        {
            Name = "Collection_CollectionInput";

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
            Field(o => o.isNewCollection, nullable: true);
            Field(o => o.CreationDate, nullable: true);
        }
    }
}
