using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka
{
    internal abstract class Pizza
    {
        protected List<string> ingridients = new List<string>();
        public Pizza()
        {
            ingridients.Add("ciasto");
        }
        public void PrintIngridients()
        {
            foreach (var ingridient in ingridients)
            {
                Console.WriteLine(ingridient);
            }
        }
    }
}
