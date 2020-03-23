using DAM.Core.GraphQL.Schemas.Events;
using DAM.Core.GraphQL.Subscriptions.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAM.Core.GraphQL.Subscriptions.Extensions
{
    public static class SubscriptionExtensions
    {
        public static IServiceCollection AddGraphQLSubscriptionControllers(this IServiceCollection services)
        {
            services
                .AddControllers()
                .AddApplicationPart(typeof(ISubscriptionService<>).Assembly);

            return services;
        }

        public static IServiceCollection AddGraphQLSubscriptionServices(this IServiceCollection services)
        {
            var subscriptionServiceType = typeof(ISubscriptionService<>);
            var serviceInterfaceType = typeof(ISubscriptionService<>);

            foreach (var eventType in EventsHelper.GetEventsGraphTypes())
            {
                var genericServiceType = serviceInterfaceType.MakeGenericType(eventType.EventType);
                var serviceType = GetSubscriptionServicesType(eventType.EventType, genericServiceType);

                if (serviceType != null)
                {
                    services.TryAdd(new ServiceDescriptor(
                        genericServiceType,
                        x => Activator.CreateInstance(serviceType, null),
                        ServiceLifetime.Singleton));
                }
            }

            return services;
        }

        private static Type GetSubscriptionServicesType(Type eventType, Type genericServiceType)
        {

            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => genericServiceType.IsAssignableFrom(p) && !p.IsInterface && !p.IsAbstract)
                .FirstOrDefault();
        }
    }
}
