using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService mathServ = new MathService();
            mathServ.MathPerformed += (result) => { Console.WriteLine(result); };

            mathServ.CalculateNumbers(2, 5, (v1, v2) => { return v1* v2; });


            Console.ReadKey();
        }
    }
}
