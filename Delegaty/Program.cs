using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty
{
    class Program
    {
        static void Main(string[] args)
        {
            RunningData rd = new RunningData();
            rd.SomeMethod(CallBackMethod); // funkcja przyjmuje inną funkcje jako delegat
            Console.ReadKey();
        }

        static void CallBackMethod(int i)
        {
            Console.WriteLine(i);
        }
    }

    class RunningData
    {
        public delegate void CallBackMethodDel(int i);//delegat do metody CallBackMethod
        public void SomeMethod(CallBackMethodDel delegat)// wskazujemy metodzie jakiego będzie przyjmowała delegata
        {
            for (int i = 0; i < 1000; i++)
            {
                delegat(i);//delegat jako uchwyt do innej metody może przyjmować parametry z metody w krórej jest wywoływana
                //to jest czadowe
                //robi się coś w tle
            }
        }
    }
}
