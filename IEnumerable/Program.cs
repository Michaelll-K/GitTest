using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lista
            List<int> myList = new List<int>();
            myList.Add(100);
            myList.Add(200);
            myList.Add(300);
            myList.Add(400);
            myList.Add(1000);
            myList.Add(1001);
            myList.Add(1002);
            #endregion

            IEnumerable<int> ienumerable = myList.AsEnumerable();

            foreach (var item in ienumerable)
            {
                Console.WriteLine(item);
            }


            IEnumerator<int> ienumerator = myList.GetEnumerator(); // IEnumerator zapamiętuje w jakim stanie jest (na jakim elemencie się zatrzymał) || wie gdzie jest jego "kursor"

            //while (ienumerator.MoveNext())
            //{
            //    Console.WriteLine(ienumerator.Current.ToString());
            //}

            Console.WriteLine();

            Pod1000(ienumerator);

            Console.ReadKey();
        }

        static void Pod1000(IEnumerator<int> enumerator)
        {
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.ToString());
                if (enumerator.Current > 999)
                    Nad1000(enumerator);// przekazanie enumeratora
            }
        }

        static void Nad1000(IEnumerator<int> enumerator)// tutaj ma tą samą wartość co w poprzedniej metodzie
        {
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.ToString());
            }
        }
    }
}
