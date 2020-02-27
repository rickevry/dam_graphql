﻿using GraphQL.Types;
using GraphQL.Utilities;
using System;

namespace DAM.Core.GraphQL.Schemas
{
    public class GraphQLSchema : Schema
    {
        public GraphQLSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<GraphQLQuery>();
            Mutation = provider.GetRequiredService<GraphQLMutation>();
        }
    }
}
