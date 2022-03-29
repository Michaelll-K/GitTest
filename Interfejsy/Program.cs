﻿using System;
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
            atak.Atak(23);
        }
    }
    
    interface IAtakMagiczny // mogą zawierać tylko metody
    {
        // nie trzeba pisać public ani abstract!!!
        void Atak(int pktAtaku); // metody w interfejsie nie zawierają ciała 
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

        void IAtakMagiczny.Atak(int pktAtaku)
        {
            Console.WriteLine("magia");
        }

        void IAtakFizyczny.Atak(int pktAtaku)
        {
            Console.WriteLine("miecz");
        }
    }
}