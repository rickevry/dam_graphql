using GraphQL.Types;
using GraphQL.Utilities;
using System;

namespace DAM.GraphQL.Schemas
{
    public class DataModelsSchema : Schema
    {
        public DataModelsSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<DataModelsQuery>();
            Mutation = provider.GetRequiredService<DataModelsMutation>();
        }
    }
}
