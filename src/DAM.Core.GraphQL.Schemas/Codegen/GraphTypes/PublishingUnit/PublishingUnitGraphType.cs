//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.PublishingUnitDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.PublishingUnitDomain
{
    public class
    PublishingUnitGraphType
    :
    ObjectGraphType<DAM.Core.Shared.Models.PublishingUnitDomain.PublishingUnit>
    {
        public PublishingUnitGraphType()
        {
            Name = "PublishingUnit_PublishingUnit";

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
