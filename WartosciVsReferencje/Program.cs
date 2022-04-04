using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WartosciVsReferencje
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 4;
            int value2 = value1;// przypisujemy wartość

            value1 = value1 + 1;

            Console.WriteLine($"pierwsza: {value1}, druga: {value2}");// pierwsza 5, druga 4


            Car bmw1 = new Car(300);// bmw1 jest tylko referencją do new Car()
            Car bmw2 = bmw1;// nie tworzymy new Car() tylko kopiujemy teferencje do poprzedniego Car

            //więc mamy jeden Car a dwie referencje :>

            bmw1.HorsePower = 350;

            Console.WriteLine($"car1: {bmw1.HorsePower}, car2: {bmw2.HorsePower}"); // obie 350

        }
    }

    class Car
    {
        public int HorsePower;
        public Car(int hp)
        {
            HorsePower = hp;
        }
    }

}
