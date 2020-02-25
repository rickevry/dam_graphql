//
//  This file was automatically generated and should not be edited.
//  2020-02-25T11:04:53.838Z
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
