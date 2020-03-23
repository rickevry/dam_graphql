using GraphQL.Types;
using GraphQL.Utilities;
using System;

namespace DAM.Core.GraphQL.Configuration
{
    public class GraphQLSchema : Schema
    {
        public GraphQLSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<GraphQLQuery>();
            Mutation = provider.GetRequiredService<GraphQLMutation>();
            Subscription = provider.GetRequiredService<GraphQLSubscription>();
        }
    }
}
