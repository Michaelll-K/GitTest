using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy // abstrakcyjna klasa zawierająca abstrakcyjne elementy
{
    class Program
    {
        static void Main(string[] args)
        {
            Postac p1 = new Postac("michal", 23);
            IAtakMagiczny atak = (IAtakMagiczny)p1;
            atak.Atak(12);
            Console.ReadKey();
        }
    }
    
    interface IAtakMagiczny // mogą zawierać tylko metody
    {
        // nie trzeba pisać public ani abstract!!!
        void Atak(int pktAtaku); // metody w interfejsie nie zawierają ciała 
        string Nazwa { get; set; }

    }



    interface IAtakFizyczny
    {
        void Atak(int pktAtaku);
    }



    // można dziedziczyć po nieskończonej ilości intefrejsów (interfejsy się implementuje a nie dziedziczy)
    class Postac : IAtakMagiczny, IAtakFizyczny
    {
        public string Imie;
        public int PunktyHP;
        public Postac(string imie, int punktyHP)
        {
            this.Imie = imie;
            this.PunktyHP = punktyHP;
        }

        public string Nazwa { get; set; }

        public void Atak(int pktAtaku)
        {
            Console.WriteLine($"Zaatakowałeś za: {pktAtaku}");
        }

        void IAtakFizyczny.Atak(int pktAtaku)
        {
            Console.WriteLine("miecz");
        }

        void IAtakMagiczny.Atak(int pktAtaku)
        {
            Console.WriteLine("różdżka");
        }
    }
}
