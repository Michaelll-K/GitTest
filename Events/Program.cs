using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            AgendaManager am = new AgendaManager();
            SMSSender sms = new SMSSender();
            //--4 jeśli delegat AddedAgenda zakrzyczy to wykonaj coś z innej klasy
            am.AddedAgenda += sms.OnAddedAgenda;//wskazujemy na metode sms | rejestrujemy event
            //             += podnosi event

            am.AddedAgendaShorter += sms.OnAddedAgendaShorter; // rejestrujemy kolejne zdarzenie 

            am.AddAgenda(new Agenda() //--1 wykonujemy AddAgenda
            { 
                AgendaDate = DateTime.Now.AddDays(2), 
                AgendaName = "kubuś puchatek" 
            });

            
            
            Console.ReadKey();
        }

    }
}
