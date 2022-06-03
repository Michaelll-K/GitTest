using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabliceListy
{
    class Program
    {
        static void WyswietlWszystkie(List<int> list)
        {
            Console.WriteLine("** Lista **");
            foreach (int item in list)
                Console.WriteLine($"{item} ");
        }
        static void Main(string[] args)
        {
            int[] test = new int[3];
            string[] cars = { "volvo", "bmw", "mazda"};

            int length = test.Length; // 3

            //-------------------------------------------------------------------

            List<int> intList = new List<int>() { 2, 4, 56, 1, 67, 3, 7, 5 };
            intList.Add(6);

            WyswietlWszystkie(intList);


            // usuwanie z listy !!!

            intList.RemoveAt(1);// usuwa określony index

            intList.RemoveAll((int x) => x > 5);// usuwa wszystkie które spełniają warunek metody
            // zamiast metody użyłem tytaj lambdy bo wykminiłem w końcu jak się to robi i zadziałało :>

            //zamiast tego
            bool MoreThan5(int x)
            {
                return x > 5;
            }

            //to: (int x) => x > 5  

            intList.Remove(1); // usuwa pierwsze wystąpienie elementu z listy

            intList.RemoveRange(2, 1);// usuwa od danego indeksu daną ilość || ([indeks rozpoczęćia], [ilość do usunięcia])

            WyswietlWszystkie(intList);

            intList.Sort();// sortuje od min do max

            WyswietlWszystkie(intList);

            Console.ReadKey();
        }

    }
}
