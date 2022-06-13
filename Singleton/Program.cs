using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Singleton
{
    internal class Program // Singleton to wzorzec który polega na tym
                           // że możemy stworzyć tylko jeden obiekt danej klasy.
    {
        static void Main(string[] args)
        {
            new Thread(() =>// Thread włącza nowy wątek
            {
                for (int i = 0; i < 100; i++)
                    Logger.Instance();
            }).Start();

            new Thread(() => // 2 x 100 chcemy wywołać metode
            {
                for (int i = 0; i < 100; i++)
                    Logger.Instance();
            }).Start();

            Logger.Instance(); // tylko raz wyświerli się wiadomość z konstruktora
            Logger.Instance();

            // pomimo że mamy 2 dodatkowe wąkti i w każdym z nich
            // Logger jest wywoływany po 100 razy to otrzymujemy
            // tylko jeden obiekt.

            Console.ReadLine();
        }
    }
}
