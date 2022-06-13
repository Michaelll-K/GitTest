using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Logger
    {
        static Logger instance = null;// tworzymy zmeinną w której będziemy przewchowywać nasz obiekt
        static readonly object lockObjcet = new object();// obiekt do blokowania wątku 
        Logger() // prywatny konstruktor (po to żęby nie można było po prostu tworzyć obiektów)
        {
            Console.WriteLine("Logger constructor called");
        }

        public static Logger Instance() // metoda która będzie nam tworzyła obiekt zamiast konstruktora
        {
            if (instance == null) // jeśli już mamy instancje to w ogóle nie musimy wykonywać lock (czasochłonne) 
            {
                lock (lockObjcet) // "lock" pozwala wejść tylko jednemu wątkowi
                { 
                    if (instance == null)// warunen który 
                        instance = new Logger();// tworzy nam nowy obiekt jeśli jeszcze go nie ma
                }
            }

            return instance; // inaczej zwraca tą która już jest
        }
    }
}
