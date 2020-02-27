using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;

namespace DAM.Core.GraphQL.SearchProxy
{
    public static class SearchProxyExtensions
    {
        public static IServiceCollection AddGraphQLSearchProxyTypes(this IServiceCollection services)
        {
            foreach (var type in SearchProxyHelper.GetTypesToRegister())
            {
                var autoRegisteringType = typeof(AutoRegisteringObjectGraphType<>).MakeGenericType(type);
                services.TryAdd(new ServiceDescriptor(
                    autoRegisteringType,
                    x => Activator.CreateInstance(autoRegisteringType, null),
                    ServiceLifetime.Transient));
            }

            return services;
        }
    }
}
