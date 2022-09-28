using AutoMapper;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    public class Town
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Citizens { get; set; }
        public Town(int id, string name, string country, int citizen)
        {
            Id = id;
            Name = name;
            Country = country;
            Citizens = citizen;
        }
    }

    internal class TownModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Citizens { get; set; }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            var bigCities = new List<Town>()
                    {
                        new Town(1, "warsazwa", "pol", 100),
                        new Town(2, "poznan", "pol", 32),
                        new Town(3, "krakow", "pol", 44),
                        new Town(4, "gdansk", "pol", 2356),
                        new Town(5, "lodz", "pol", 3)
                    };

            Extensions authorization = new Extensions();

            bigCities = bigCities.Where(c => authorization.AtLeast100(c)).ToList();

            foreach (var item in bigCities)
            {
                Console.WriteLine($"{item.Name} {item.Citizens}");
            }


            Console.ReadKey();

        }


    }

    public class Extensions
    {
        public bool AtLeast100(Town town)
        {
            if (town.Citizens < 100)
                return false;

            return true;
        }
    }

    public class Resource<T> : Statement
    {
        public T Result { get; set; }
        public dynamic Meta { get; set; }

        #region Resource()
        public Resource() : base()
        {
            Meta = new ExpandoObject();
        }

        public Resource(T data) : this()
        {
            Result = data;
        }
        #endregion
    }


    public class Statement
    {
        public int Code { get; }

        public string Message { get; set; }

        public Statement(int code = 200, string message = null)
        {
            Code = code;
            Message = message;
        }
    }


}
