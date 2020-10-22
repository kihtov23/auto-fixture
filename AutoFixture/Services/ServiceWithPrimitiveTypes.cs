using System;
using System.Collections.Generic;
using System.Text;

namespace AutoFixtureDemo.Services
{
    public class ServiceWithPrimitiveTypes : IServiceWithPrimitiveTypes
    {
        public string Name { get; set; }

        public ServiceWithPrimitiveTypes(string parameter1, int parameter2)
        {
            
        }
    }
}
