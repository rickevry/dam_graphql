//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.SampleDomain;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.SampleDomain
{
    public class CategoryMutableGraphType : ObjectGraphType<CategoryModel>
    {
        public CategoryMutableGraphType()
        {
            Name = "SampleMutable_Category";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.CategoryType, nullable: true);
        }
    }
}
