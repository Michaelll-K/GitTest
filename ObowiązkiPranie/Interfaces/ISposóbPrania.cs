using ObowiązkiPranie.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObowiązkiPranie.Interfaces
{
    internal interface ISposóbPrania
    {
        CzystePranie Upierz(BrudnePranie brudnePranie);
    }
}
