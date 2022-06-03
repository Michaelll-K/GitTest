using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slownik
{
    class Program
    {
        private static Dictionary<string, Currency> GetCurrencies() // metoda zwraca słownik
        {
            return new Dictionary<string, Currency> // tworzenie słownika || klucze muszą być unikalne
            {  // klucz   wartość
                { "usd", new Currency("usd", "", 1) },
                { "eur", new Currency("eur", "", 2) },
                { "gbp", new Currency("gbp", "", 3) },
                { "cad", new Currency("cad", "", 4) },
                { "inr", new Currency("inr", "", 5) },
                { "mxn", new Currency("mxn", "", 6) },
            };
        }

        static void Main(string[] args)
        {
            Dictionary<string, Currency> currencies = GetCurrencies();
            Console.WriteLine("Check for: ");
            string userInput = Console.ReadLine();

            //Currency currency = currencies[userInput]; // odwołujemy się do klucza || mówimy aby wyrzuciło nam wartość zgodną z kluczem który wpisał użytkownik
            //jesli klucz nie istnieje to wywala błąd
            Currency currency = null;
            if (currencies.TryGetValue(userInput, out currency))
                Console.WriteLine($"{currency.Name} is {currency.Value}");
            else
                Console.WriteLine("Wrong name");

            currencies.Remove("mxn");// usuwa element

            currencies.Add("pln", new Currency("pln", "", 124));

            //currencies.TryAdd("pln", new Currency("pln", "", 124)); //<- nwm czm nie dziala
            Console.ReadKey();
        }
    }
}
