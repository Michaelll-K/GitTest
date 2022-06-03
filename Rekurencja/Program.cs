using System;

namespace Rekurencja
{
    class Program
    {
        static void Main(string[] args)
        {
            f(8);
        }

        static void f(int n)
        {
            if (n > 0)
            {
                Console.Write(n + " ");
                f(n - 2);
                Console.Write(n + " ");
            }
        }
    }
}
