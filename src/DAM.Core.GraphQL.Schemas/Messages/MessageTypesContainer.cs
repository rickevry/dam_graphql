using System;

namespace DAM.Core.GraphQL.Schemas.Messages
{
    public class MessageTypesContainer
    {
        public Type RepositoryType { get; set; }
        public Type CommandType { get; set; }
        public Type ResultType { get; set; }
        public Type CommandGraphType { get; set; }
        public Type ResultGraphType { get; set; }
    }
}
