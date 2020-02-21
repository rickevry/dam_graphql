//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:59.186Z
//
using System;
using System.Collections.Generic;
using GraphQL.Types;

namespace DAM.Core.GraphQL.Schemas.Sample
{
    public class CategoryInputGraphType : InputObjectGraphType<CategoryModel>
    {
        public CategoryInputGraphType()
        {
            Name = "Sample_CategoryInput";

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.CategoryType, nullable: true);
        }
    }
}
