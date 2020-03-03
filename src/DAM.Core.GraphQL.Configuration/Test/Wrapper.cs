using GraphQL.Types;
using System.Collections.Generic;

namespace DAM.Core.GraphQL.Configuration
{
    public class WrapperGraphType : UnionGraphType
    {
        public WrapperGraphType()
        {
            Type<InvoiceGraphType>();
            Type<DrawingGraphType>();
        }
    }
}
