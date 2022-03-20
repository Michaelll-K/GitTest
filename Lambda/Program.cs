using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 76 };

            //var numberOver5 = new List<int>();

            //foreach (var item in numberOver5)
            //{
            //    if (item > 5) numberOver5.Add(item);
            //}

            List<int> numberOver5 = numbers.Where(x => x > 5).ToList();
            // stwórz listę "numberOver5" z elementów "x" z listy "numbers" jeśli są większe od 5


            var gameList = new List<Game>
            {
                new Game{Name = "Dark souls", Score = 9},
                new Game{Name = "Battlefield", Score = 4},
                new Game{Name = "Lol", Score = 9},
                new Game{Name = "Subnautica", Score = 33},
                new Game{Name = "mINECRAFT", Score = 33}
            };

            bool allHaveOver9Score = gameList.All(x => x.Score >= 9); // false

            List<string> gameNames = gameList.Select(x => x.Name).ToList();

            List<StarRating> starsList = gameList.Select(x => new StarRating { GameName = x.Name, Stars = x.Score * 0.5 }).ToList();

            Game gameWithScoreOf2 = gameList.FirstOrDefault(x => x.Score == 2);
            //wybierz grę która ma score równy 2 | jeśli nie znajdzie to wstawia null

            Random _random = new Random();

            var suggestedGames = gameList // używanie LINQ
                .Where(x => x.Score >= 9)
                .OrderBy(X => _random.Next())
                .Take(3)
                .Select(x => $"{x.Name} - {x.Score}")
                .ToList();

            suggestedGames.ForEach(x => Console.WriteLine(x)); // <3

            Console.ReadKey();

        }
    }
}
