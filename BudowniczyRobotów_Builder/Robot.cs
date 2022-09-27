using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace BudowniczyRobotów_Builder
{
    internal class Robot
    {
        [DisplayProperty("Nazwa Robota: ")]
        public string Name { get; set; }
        [DisplayProperty("Materiał: ")]
        public Materials Material { get; set; }
        [DisplayProperty("Funkcja: ")]
        public string Functionality { get; set; }
        [DisplayProperty("Broń: ")]
        public Wepon Wepon { get; set; }
        [DisplayProperty("Ilość życia: ")]
        public int Health { get; set; }

        public Robot(string name, Materials materials, string functionality, Wepon wepon, int health)
        {
            Name = name;
            Material = materials;
            Functionality = functionality; 
            Wepon = wepon;
            Health = health;
        }

        internal static RobotBuilder NewRobotBuilder()
        {
            return new RobotBuilder();
        }

        public void ShowRobot()
        {
            var properties = this.GetType().GetProperties();

            foreach (var prop in properties)
            {
                var atrybut = prop.GetCustomAttribute<DisplayPropertyAttribute>();
                var value = prop.GetValue(this);

                Console.Write(atrybut.DisplayName);

                if (Wepon.GetType().Equals(value.GetType()))
                {
                    var weponProp = value.GetType().GetProperties();
                    foreach (var wProp in weponProp)
                    {
                        Console.Write($"{wProp.GetCustomAttribute<DisplayPropertyAttribute>().DisplayName}" +
                            $"{wProp.GetValue(Wepon)} ");
                    }
                }
                else
                {
                    Console.Write(value);
                }



/*                if (propTyp == weponTyp)
                {
                    Console.Write(atrybut.DisplayName);

                    var wlasciwosci = prop.GetType().GetProperties();

                    foreach (var wlas in wlasciwosci)
                    {
                        Console.Write(wlas.Name + " " + wlas.GetValue(this) + " ");
                    }
                }
                else
                {
                    Console.Write(atrybut.DisplayName + prop.GetValue(this));
                }*/

                Console.WriteLine();
            }



        }
    }
}
