using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DAM.Core.GraphQL.SearchProxy
{
    public static class SearchProxyHelper
    {
        internal static IEnumerable<Type> GetTypesToRegister()
        {
            Assembly assembly = Assembly.GetAssembly(typeof(SearchProxyHelper));
            return assembly.GetTypes().Where(x =>
                !x.IsAbstract &&
                x.Namespace == "DAM.Core.GraphQL.SearchProxy.Schemas");
        }
    }
}
