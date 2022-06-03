using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection; // trzeba dodać przy GetCustomAttribute
using System.Text;
using System.Threading.Tasks;

namespace RefleksjaAtrybuty
{
    class Program
    {
        //Atrybuty w innych klasach^ 
        //Refleksja:
        static void Display(object obj) // przyjmujemy obiekt w metodzie żęby móc zrobić jedną dla wszystkich
        {
            Type objType = obj.GetType(); // zwraca typ obiektu
            var properies = objType.GetProperties(); // zwraca tablicę właściwości

            foreach (var prop in properies)
            {
                var valueProp = prop.GetValue(obj);
                var type = valueProp.GetType();

                if (type.IsPrimitive || type == typeof(string)) // IsPrimitive  sprawdza czy typ jest typem prymitywnym, string nie jest typem prymitywnym
                {
                    var attribute = prop.GetCustomAttribute<DisplayPropertyAttribute>(); //zwraca null lub obiekt typu DisplayPropertyAttribute

                    if (attribute != null)
                        Console.WriteLine($"{attribute.DisplayName}: {valueProp}");//na obiektach atrybutów można wyciągać pojedyncze atrybuty
                    else
                        Console.WriteLine($"{prop.Name}: {valueProp}");

                }
            }
        }
        static void Main(string[] args)
        {
            Address address = new Address()
            {
                City = "Warszawa",
                PostalCode = "12-345",
                Street = "Poznańska 2"
            };

            Person person = new Person() 
            { 
                FirstName = "Adam",
                LastName = "Nowak",
                Age = 5,
                Address = address
            };

            Console.WriteLine("Person: ");
            Display(person);

            Console.WriteLine("Podaj włąściwość do zmiany:");
            var propToChange = Console.ReadLine();

            Console.WriteLine("Wartość właściwości:");
            var vatule = Console.ReadLine();


            ChangeValue(person, propToChange, vatule);
            Display(person);

            Console.ReadLine();
        }

        static void ChangeValue<T>(T obj, string propName, string value) // metoda genetyczna?
        {
            var objType = typeof(T);// ?
            var prop = objType.GetProperty(propName);
            if (prop != null)
            {
                prop.SetValue(obj, value); // metoda .SetValue może być wywołana na właściwościach
            }
        }
    }
}
