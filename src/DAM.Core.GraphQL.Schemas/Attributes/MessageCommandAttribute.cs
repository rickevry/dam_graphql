using System;

namespace DAM.Core.GraphQL.Schemas.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class MessageCommandAttribute : Attribute
    {
        public MessageCommandAttribute(Type entityType, Type commandType, Type resultType, Type resultGraphType)
        {
            EntityType = entityType;
            CommandType = commandType;
            ResultType = resultType;
            ResultGraphType = resultGraphType;
        }

        public Type EntityType { get; set; }
        public Type CommandType { get; set; }
        public Type ResultType { get; set; }
        public Type ResultGraphType { get; set; }
    }
}
