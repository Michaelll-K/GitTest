using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    public class AgendaManager
    {
        public delegate void AddedAgendaEventHandler(object o, AgendaEventArgs e);
        public event AddedAgendaEventHandler AddedAgenda;

        // narzędzia do tworzenia eventów:
        // EventHandler
        // EventHandler<TEventArgs>
        public event EventHandler<AgendaEventArgs> AddedAgendaShorter;// !!!!!!!!!

        /// <summary>
        /// Event publisher powinien być (konwencja)
        /// 1. protected
        /// 2. virtual
        /// 3. void
        /// 4. Nazwa powinna zaczynać się od "On"
        /// </summary>
        protected virtual void OnAddedAgenda(Agenda newAgenda)
        {
            if (AddedAgenda != null) // --3 delegat się wykona i on będzie krzyczał że coś się stało
                AddedAgenda(this, new AgendaEventArgs { Agenda = newAgenda});//uzupełniamy nasze argumenty
            //ustawiamy event AddedAgenda na to żeby posiadał newAgenda dzięki naszym argumentom
        }

        protected virtual void OnAddedAgendaShorter(Agenda newAgenda)
        {
            if (AddedAgendaShorter != null)
                AddedAgendaShorter(this, new AgendaEventArgs { Agenda = newAgenda });
        }


        public void AddAgenda(Agenda newAgenda)
        {
            Console.WriteLine("AddAgenda: Zaczynam dodawac ...");
            Thread.Sleep(3000);
            //tu !!
            //--2 w AddAgenda jest metoda przekierowująca do delegata
            OnAddedAgenda(newAgenda);//inicjujemy nasz publisher (Coś co będzie "krzyczało" że coś się stało
                                     //w tym przypadku skończyło się dodawnie)

            OnAddedAgendaShorter(newAgenda);
            Console.WriteLine("AddAgenda: Skonczylem dodawac ...");
        }
    }
}
