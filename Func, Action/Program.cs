using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func__Action
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<T> skraca tworzenie delegatu (pierwsze parametry to parametry wejściowe a ostatni to wyjściowy)
            Func<double, double> cpointer = r => Math.PI * r * r;

            double area = cpointer(20);


            //Action<T> nie zwraca niczego (też skraca delegady)
            Action<string> MyAction = s => Console.WriteLine(s);

            MyAction("To ja!");

            //Predicate<> zwraca tylko true/false
            Predicate<string> ChackIfGraderThan5 = x => x.Length > 5;
            Console.WriteLine(ChackIfGraderThan5("alamakota"));



        }


        //public delegate double CalculatorAreaPointer(double r);

        //double area = cpointer(20);
        //CalculatorAreaPointer cpointer = new CalculatorAreaPointer( delegate(double r) { return Math.PI * r * r; });
        //                                                      //tworzymy delegata w locie
        //double area = cpointer(20);

        //CalculatorAreaPointer cpointer = r => Math.PI * r * r; // używanie lambdy
        //double area = cpointer(20);
    }
}
