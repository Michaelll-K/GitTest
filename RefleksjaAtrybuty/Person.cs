using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefleksjaAtrybuty
{
    //[DisplayProperty("Citizen")]
    class Person
    {
        //nazwa klasy atrybutu (co chcemy w atrybucie umieścić)
        [DisplayProperty("First Name")]
        public string FirstName { get; set; }
        [DisplayProperty("Last Name")]
        public string LastName { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        //public void Work([DisplayProperty("value")] string value)// da się dodawać atrybuty do parametrów
        //{

        //}
    }
}
