//
//  This file was automatically generated and should not be edited.
//
using System;
using System.Collections.Generic;
using DAM.Core.Shared.Models.Sample;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Sample
{
    public class CategoryGraphType : ObjectGraphType<CategoryModel>
    {
        public CategoryGraphType()
        {
            Name = "Sample_Category";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.CategoryType, nullable: true);
        }
    }
}
