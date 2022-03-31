using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime before = now.Subtract(new TimeSpan(7, 0, 0, 0));
            DateTime after = now.AddDays(2);
            //ExtensionMethods to metody rozszerzające już istniejące metody - czyli możemy np dodać jakąś własną metodę do stringa czy DateTime
            //Extensions.IsDateBetween()

            bool isBetween = now.IsBetween(before, after);//używamy metody jako rozszenie

            var number = 4.5;

            var n2 = number.Square();// no to jest fajne
            
        }
    }
}
