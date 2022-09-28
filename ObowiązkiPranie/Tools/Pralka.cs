using ObowiązkiPranie.Interfaces;
using ObowiązkiPranie.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObowiązkiPranie.Tools
{
    internal class Pralka : ISposóbPrania
    {
        public CzystePranie Upierz(BrudnePranie brudnePranie)
        {
            Console.WriteLine("Wyprano w pralce");

            CzystePranie czystePranie = new CzystePranie(brudnePranie.Nazwa);

            return czystePranie;
        }
    }
}
