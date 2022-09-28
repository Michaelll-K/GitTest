using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj nazwe");
            var pizzaType = Console.ReadLine();

            var fabryka = new PizzaFactory(); // towrzymy fabryke

            var pizza = fabryka.GetPizza(pizzaType); // na fabryce wywołujemy metode tworzącą

            pizza.PrintIngridients();

            Console.ReadKey();
        }
    }
}
