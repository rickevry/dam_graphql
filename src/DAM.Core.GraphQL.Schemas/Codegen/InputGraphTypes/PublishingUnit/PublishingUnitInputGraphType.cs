//
//  This file was automatically generated and should not be edited.
//  2020-02-28T09:54:22.411Z
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.PublishingUnit;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.PublishingUnit
{
    public class
    PublishingUnitInputGraphType
    : InputObjectGraphType<PublishingUnitModel>
    {
        public PublishingUnitInputGraphType()
        {
            Name = "PublishingUnit_PublishingUnitInput";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Folders, nullable: true);
            Field(o => o.Title, nullable: true);
            Field(o => o.CreatedDate, nullable: true);
            Field(o => o.CreatedBy, nullable: true);
            Field(o => o.ModifiedDate, nullable: true);
            Field(o => o.ModifiedBy, nullable: true);
        }
    }
}