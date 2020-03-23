﻿using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAM.Core.GraphQL.Configuration
{
    public class HostedServiceAccessor<T>
        where T : IHostedService
    {
        public HostedServiceAccessor(IEnumerable<IHostedService> hostedServices)
        {
            foreach (var service in hostedServices)
            {
                if (service is T match)
                {
                    Service = match;
                    break;
                }
            }
        }

        public T Service { get; }
    }
}
