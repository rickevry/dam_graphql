using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAM.Core.GraphQL.Server.Configuration
{
    public class GraphQLSettings
    {
        public bool EnableMetrics { get; set; }

        public bool ExposeExceptions { get; set; }
    }
}
