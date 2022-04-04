using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolejkiStosy
{
    class Program
    {
        static void Main(string[] args)
        {
            //kolejka
            Queue<int> queue = new Queue<int>(); // torzenie kolejki || dokładanie do kolejki dokłada na sam dół!!!!!!!!!

            //elementy są usystematyzowane, w ten sam sposób trzeba wyciągać z niej rzeczy
            queue.Enqueue(1); // dodawanie elementu do kolejki (kolejkowanie)
            queue.Enqueue(2);
            queue.Enqueue(3);

            //queue[0]   nie możemy zastosować indeksowania

            Console.WriteLine(queue.Peek());// queue.Peek() zwraca obiekt na SAMEJ GÓRZE ale go nie usuwa - 1

            Console.WriteLine(queue.Dequeue());// queue.Dequeue() zwraca obiekt z wierzchu i go usuwa
            Console.WriteLine(queue.Dequeue());

            //-------------------------------------------------------------------------------------------------------------------------------

            //stos
            Stack<int> stack = new Stack<int>();
            stack.Push(1); // dodawanie na samą górę, a nie na dół
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Peek());//zwrócenie wartości z góry, bez usuwania - 3
            Console.WriteLine(stack.Pop());//zwraca z góry i usuwa - 3
            Console.WriteLine(stack.Pop());// - 2
            stack.Push(9);
            Console.WriteLine(stack.Pop());// - 9


            Console.Read();
        }
    }
}
