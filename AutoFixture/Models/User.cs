using System;
using System.Collections.Generic;
using System.Text;

namespace AutoFixtureDemo.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<string> PatNames { get;  set; } = new List<string>();
    }
}
