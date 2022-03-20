using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class SMSSender
    {

        public void OnAddedAgenda(object o, AgendaEventArgs e)// OnAddedAgenda przyjmuje Agende z naszych argumentów
        {
            Console.WriteLine("SMS Sender: sms został wysłany !!! Data" + e.Agenda.AgendaDate + " Tytuł " + e.Agenda.AgendaName);//--4 wykonanie

        }

        public void OnAddedAgendaShorter(object o, AgendaEventArgs e)// t0talny czad
        {
            Console.WriteLine("SMS Sender Shorter!!!!: sms został wysłany !!! Data" + e.Agenda.AgendaDate + " Tytuł " + e.Agenda.AgendaName);

        }
    }
}
