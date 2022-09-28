using ObowiązkiPranie.Controlers;
using ObowiązkiPranie.Items;
using ObowiązkiPranie.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObowiązkiPranie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenagerPrania mp = new MenagerPrania();

            BrudnePranie brudneSpodnie = new BrudnePranie("Spodnie");

            mp.ZrobPranie(brudneSpodnie, new Pralka());

            Console.ReadKey();
        }
    }
}
