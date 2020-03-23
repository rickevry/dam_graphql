using DAM.Core.GraphQL.Schemas.Events;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;

namespace DAM.Core.GraphQL.Schemas.Messages
{
    public static class EventsExtenstions
    {
        public static IServiceCollection AddGraphQLSubscriptionTypes(this IServiceCollection services)
        {
            foreach (var type in EventsHelper.GetEventsGraphTypes())
            {
                services.TryAdd(new ServiceDescriptor(
                    type.EventGraphType,
                    x => Activator.CreateInstance(type.EventGraphType, null),
                    ServiceLifetime.Transient));
            }

            return services;
        }
    }
}
