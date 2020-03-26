using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;

namespace DAM.Core.GraphQL.Schemas.Messages
{
    public static class MessagesExtenstions
    {
        public static IServiceCollection AddGraphQLMessageTypes(this IServiceCollection services)
        {
            foreach (var type in MessagesHelper.GetMessagesGraphTypes())
            {
                services.TryAdd(new ServiceDescriptor(
                    type.CommandGraphType,
                    x => Activator.CreateInstance(type.CommandGraphType, null),
                    ServiceLifetime.Transient));

                services.TryAdd(new ServiceDescriptor(
                    type.ResultGraphType,
                    x => Activator.CreateInstance(type.ResultGraphType, null),
                    ServiceLifetime.Transient));
            }

            return services;
        }
    }
}
