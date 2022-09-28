using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObowiązkiPranie.Items
{
    internal class BrudnePranie
    {
        public string Nazwa { get; set; }
        public BrudnePranie(string nazwa)
        {
            Nazwa = nazwa;
        }

        public void Sprawdź()
        {
            Console.WriteLine("Brudne " + Nazwa);
        }
    }
}
