using DAM.Core.GraphQL.Configuration.Repositories;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DAM.Core.GraphQL.Configuration
{
    public class GraphQLSubscription : ObjectGraphType
    {
        private readonly IServiceProvider _serviceProvider;

        public GraphQLSubscription(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            CreateDataRepositorySpecificFields();
        }

        private void CreateDataRepositorySpecificFields()
        {
            _serviceProvider.GetRequiredService<AssetRepositoryConfiguration>().ConfigureGraphQLSubscriptionFields(this);
            _serviceProvider.GetRequiredService<FolderRepositoryConfiguration>().ConfigureGraphQLSubscriptionFields(this);
        }
    }
}