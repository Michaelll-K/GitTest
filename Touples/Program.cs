using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            //generic tuple class
            Tuple<string, int> tuple = new Tuple<string, int>("cos", 23);//kolekcja różnych typów zmiennych

            var pierwszyItemZTuple = tuple.Item1;
            var drugiItemZTuple = tuple.Item2;

            //value tuple
            var vTuple = ("cos", 23);//krótsza forma tuple


            //named tuples
            var namedTuple = (nazwa: "cos", liczba: 34); // czaaaaaaaaaaad
                           //np imie gracza | np id gracza
            var liczbaZNameTuple = namedTuple.liczba;


        }

        static Tuple<int,string> FunkcjaZwracajacaDwaRodzajeZmiennych()
        {
            return new Tuple<int, string>(22, "musi zwracac taki sam tuple");
        }

        static (int numer, string opis) LepszaFunkcjaZwracajacaDwaRodzajeZmiennych() // od razu nazwane pola
        {
            return (numer: 22, opis: "musi zwracac taki sam tuple");
        }
    }
}
