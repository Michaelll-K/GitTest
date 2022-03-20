using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    // musi dziedziczyć z EventArgs
    public class AgendaEventArgs : EventArgs // klasa argumentów (własnych) które mogą przekazywać elementy przez delegaty
    {
        //chcemy przesłać cały obiekt Agenda więc
        public Agenda Agenda { get; set; }// tworzymy właściwość o typie Agenda
        // przez to że jest on w naszej klasie do argumentów będziemy mogli go później użyć jako przekazwyany argument
    }
}
