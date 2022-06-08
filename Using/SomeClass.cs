using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using
{
    internal class SomeClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Disposing SomeClass");
        }

        internal void SayHi()
        {
            Console.WriteLine("Hi");
        }
    }
}
