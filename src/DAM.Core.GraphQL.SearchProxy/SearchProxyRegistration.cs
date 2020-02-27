using GraphQL.Types;
using GraphQL.Utilities;

namespace DAM.Core.GraphQL.SearchProxy.Services
{
    public static class SearchProxyRegistration
    {
        public static void RegisterSearchSchemaTypes()
        {
            foreach (var type in SearchProxyHelper.GetTypesToRegister())
            {
                GraphTypeTypeRegistry.Register(
                    type, 
                    typeof(AutoRegisteringObjectGraphType<>).MakeGenericType(type));
            }
        }
    }
}
