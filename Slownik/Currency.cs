using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slownik
{
    class Currency
    {
        public Currency(string Name, string FullName, int Value)
        {
            this.Name = Name;
            this.FullName = FullName;
            this.Value = Value;
        }
        public string Name { get; set; }
        public string FullName { get; set; }
        public int Value { get; set; }
    }
}
