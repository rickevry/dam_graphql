using DAM.Core.GraphQL.Schemas.Codegen.Events;
using DAM.Core.GraphQL.Subscriptions.Interfaces;
using DAM.Core.Messages;
using DAM.Core.Messages.AssetDomain;
using GraphQL.Resolvers;
using GraphQL.Subscription;
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

            AddField(new EventStreamFieldType
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