//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.PublishingUnit;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.PublishingUnit
{
    public class FolderInputGraphType : InputObjectGraphType<FolderModel>
    {
        public FolderInputGraphType()
        {
            Name = "PublishingUnit_FolderInput";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.CreatedDate, nullable: true);
            Field(o => o.CreatedBy, nullable: true);
            Field(o => o.ModifiedDate, nullable: true);
            Field(o => o.Title, nullable: true);
            Field(o => o.ModifiedBy, nullable: true);
            Field(o => o.Folders, nullable: true);
        }
    }
}
