using DAM.Core.GraphQL.Repository;
using DAM.Core.GraphQL.Schemas.AssetDomain;
using DAM.Core.GraphQL.Schemas.Codegen.Events;
using DAM.Core.GraphQL.Subscriptions.Interfaces;
using DAM.Core.Messages;
using DAM.Core.Messages.AssetDomain;
using GraphQL;
using GraphQL.Resolvers;
using GraphQL.Subscription;
using GraphQL.Types;
using GraphQL.Utilities;
using System;

namespace DAM.Core.GraphQL.Configuration.Repositories
{
    public class AssetRepositoryConfiguration : IRepositoryConfiguration
    {
        private readonly IAssetRepository _repository;
        private readonly IServiceProvider _serviceProvider;

        public AssetRepositoryConfiguration(
            IServiceProvider serviceProvider,
            IAssetRepository repository)
        {
            _serviceProvider = serviceProvider;
            _repository = repository;
        }

        public void ConfigureGraphQLMutationFields(ObjectGraphType parent)
        {
        }

        public void ConfigureGraphQLQueryFields(ObjectGraphType parent)
        {
            parent.Field<ListGraphType<AssetGraphType>>(
                "GetAssetsInFolder",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<GuidGraphType>> { Name = "folderId" }
                ),
                resolve: context =>
                {
                    var folderId = context.GetArgument<Guid>("folderId");
                    return _repository.GetAssetsInFolderAsync(folderId);
                });
        }

        public void ConfigureGraphQLSubscriptionFields(ObjectGraphType parent)
        {
            parent.AddField(new EventStreamFieldType
            {
                Name = nameof(AssetPublishedEvent),
                Type = typeof(AssetPublishedEventGraphType),
                Resolver = EventDataResolver<AssetPublishedEvent>(),
                Subscriber = EventDataObservable<AssetPublishedEvent>(),
            });
        }

        FuncFieldResolver<TDataEvent> EventDataResolver<TDataEvent>() where TDataEvent : class, IDataEvent
        {
            return new FuncFieldResolver<TDataEvent>((IResolveFieldContext arg) =>
            {
                var result = arg.Source as TDataEvent;
                return result;
            });
        }

        EventStreamResolver<TDataEvent> EventDataObservable<TDataEvent>() where TDataEvent : class, IDataEvent
        {
            var srv = _serviceProvider.GetRequiredService<ISubscriptionService<TDataEvent>>();

            return new EventStreamResolver<TDataEvent>((IResolveEventStreamContext arg) =>
            {
                return srv.GetObservable();
            });
        }
    }
}
