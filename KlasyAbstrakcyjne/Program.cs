using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyAbstrakcyjne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zwierze zwierze = new Zwierze(); // nie da sie stworzyć klasy abstrakcyjnej

            Ssak ssak = new Ssak();
            ssak.Przedstaw_Sie();

            Kot k = new Kot();
            k.Przedstaw_Sie();

            Console.Read();
        }
    }

    //klasy abstrakcyjne są po to żeby nie można było jej wywołać ale żeby można było po niej dziedziczyć :>

    public abstract class Zwierze // KLASA abstrakcyjna 
    {
        public void Jabko()
        {
            int a;
        }
        public abstract void Przedstaw_Sie(); // METODY abstrakcyjne
    }

    public class Ssak : Zwierze
    {
        public override void Przedstaw_Sie()
        {
            Console.WriteLine("Ssak");
        }
    }

    public class Kot : Ssak
    {
        public override void Przedstaw_Sie()
        {
            Console.WriteLine("Kot");
        }
    }
}
