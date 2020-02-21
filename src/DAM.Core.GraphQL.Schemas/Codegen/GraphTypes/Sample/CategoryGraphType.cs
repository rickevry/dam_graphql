//
//  This file was automatically generated and should not be edited.
//  2020-02-21T17:25:59.186Z
//
using System;
using System.Collections.Generic;
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
