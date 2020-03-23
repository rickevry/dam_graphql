using DAM.Core.GraphQL.Schemas.Attributes;
using DAM.Core.GraphQL.Schemas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Events
{
    public static class EventsHelper
    {
        private static ICollection<EventTypesContainer> _typesCache;

        public static IEnumerable<EventTypesContainer> GetEventsGraphTypes()
        {
            if (_typesCache == null)
            {
                CreateTypesCache();
            }

            return _typesCache;
        }

        private static void CreateTypesCache()
        {
            var type = typeof(IDataEventGraphType);
            var eventGraphTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface && !p.IsAbstract);

            _typesCache = new List<EventTypesContainer>();

            foreach (var eventGraphType in eventGraphTypes ?? Enumerable.Empty<Type>())
            {
                var eventType = eventGraphType.BaseType.GetGenericArguments()?.First();

                if (eventType != null)
                {
                    _typesCache.Add(new EventTypesContainer
                    {
                        EventType = eventType,
                        EventGraphType = eventGraphType,
                    });
                }
            }
        }
    }
}
