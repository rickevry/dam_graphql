using GraphQL.Types;

namespace DAM.Core.GraphQL.Configuration.Repositories
{
    public interface IRepositoryConfiguration
    {
        void ConfigureGraphQLQueryFields(ObjectGraphType parent);
        void ConfigureGraphQLMutationFields(ObjectGraphType parent);
        void ConfigureGraphQLSubscriptionFields(ObjectGraphType parent);
    }
}
