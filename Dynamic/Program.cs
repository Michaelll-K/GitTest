using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic tojestDynamic = "aa";
            tojestDynamic.ToUpper(); // nie ma żadnych podpowiedzi || ale nie ma też błędu


            int mint = 1 + 3;
            var mvar = 1 + 3;
            dynamic dyn = 1 + 3;
            object obj = 1 + 3;

            Console.WriteLine(mint.GetType());
            Console.WriteLine(mvar.GetType());
            Console.WriteLine(dyn.GetType());
            Console.WriteLine(obj.GetType());


            dynamic dyna;
            int a = 20;

            dyna = a;

            string b = "To jest dynamic !!";

            dyna = b;

            DateTime dt = DateTime.Now;

            dyna = dt;

        }
    }
}
