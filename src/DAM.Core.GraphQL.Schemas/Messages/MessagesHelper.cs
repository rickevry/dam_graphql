using DAM.Core.GraphQL.Schemas.Attributes;
using DAM.Core.GraphQL.Schemas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAM.Core.GraphQL.Schemas.Messages
{
    public static class MessagesHelper
    {
        private static ICollection<MessageTypesContainer> _typesCache;

        public static IEnumerable<MessageTypesContainer> GetMessagesGraphTypes()
        {
            if (_typesCache == null)
            {
                CreateTypesCache();
            }

            return _typesCache;
        }

        private static void CreateTypesCache()
        {
            var type = typeof(IDataCommandGraphType);
            var commandGraphTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface && !p.IsAbstract);

            _typesCache = new List<MessageTypesContainer>();

            foreach (var commandGraphType in commandGraphTypes ?? Enumerable.Empty<Type>())
            {
                var dataCommandAttribute = commandGraphType
                    .GetCustomAttributes(typeof(MessageCommandAttribute), false)
                    .Select(qn => qn as MessageCommandAttribute).FirstOrDefault();

                if (dataCommandAttribute != null)
                {
                    _typesCache.Add(new MessageTypesContainer
                    {
                        RepositoryType = dataCommandAttribute.EntityType,
                        CommandType = dataCommandAttribute.CommandType,
                        CommandGraphType = commandGraphType,
                        ResultType = dataCommandAttribute.ResultType,
                        ResultGraphType = dataCommandAttribute.ResultGraphType,
                    });
                }
            }
        }
    }
}
