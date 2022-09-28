using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka
{
    internal class PizzaFactory
    {
        public Pizza GetPizza(string name)  //towrzymy metode która zwraca abstrakcje (Pizza)
        {
            Pizza pizza = null;
            if (name == "margharitta")
                pizza = new Margharitta();
            else if (name == "quattaro")
                pizza = new Quattaro();
            else
                pizza = new Margharitta();

            return pizza;
        }
    }
}
