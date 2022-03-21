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

            IEnumerator<int> ienumerator = myList.GetEnumerator();

            while (ienumerator.MoveNext())
            {
                Console.WriteLine(ienumerator.Current.ToString());
            }

            Console.ReadKey();
        }
    }
}
