using ObowiązkiPranie.Interfaces;
using ObowiązkiPranie.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObowiązkiPranie.Controlers
{
    internal class MenagerPrania
    {
        public void ZrobPranie(BrudnePranie brudnePranie, ISposóbPrania sposóbPrania)
        {
            brudnePranie.Sprawdź();

            CzystePranie czystePranie = sposóbPrania.Upierz(brudnePranie);

            czystePranie.Sprawdź();
        }
    }
}
