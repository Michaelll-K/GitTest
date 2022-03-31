using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class Extensions // jesli chcemy stworzyć metodę rozszerzającą nasza klasa musi być statyczna
    {
        //zwyczajna metoda którą musimy wywoływać Extensions.IsDateDetween()
        public static bool IsDateBetween(DateTime date, DateTime from, DateTime to)
        {
            return date > from && date < to;
        }

        public static bool IsBetween(this DateTime date, DateTime from, DateTime to)
        {//           musimy dopisać this jeśli chcemy stworzyć metodę rozszerzającą
            return date > from && date < to;
        }

        public static double Square(this double x)
        {
            return x * x;
        }
    }
}
