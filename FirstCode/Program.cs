using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    class Program
    {
        static void Main(string[] args)
        {

            new List<string>
            { 
                "Steve", "Joe", "Marry", "Julie"
            }
            .ForEach(x => Console.WriteLine(x));

            Console.WriteLine();

            new List<string>
            { 
                "Tom", "Dick", "Harry" 
            }
            .ForEach(x => Console.WriteLine(x));

            Console.ReadKey();
        }
    }
}
