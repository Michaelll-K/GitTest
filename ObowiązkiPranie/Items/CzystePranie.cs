using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObowiązkiPranie.Items
{
    internal class CzystePranie
    {
        public string Nazwa { get; set; }

        public CzystePranie(string nazwa)
        {
            Nazwa = nazwa;
        }

        public void Sprawdź()
        {
            Console.WriteLine("Czyste " + Nazwa);
        }
    }
}
