using System;
using System.Linq;

namespace DerbyWinners
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var searchParameters = new HorseSearch
            {
                YearWon = "2020",
                Horse = "Winner",
                Jockey = "Jockey",
                Trainer = "Trainer",
                Owner = "Owner",
                Page = 0,
                PageSize = 5
            };
            Console.WriteLine("Type any key to begin search");
            var horses = KentuckyDerbyWinners.LoadHorses();

            while (Console.ReadKey().KeyChar != 'q')
            {
                Console.WriteLine($"Page: {searchParameters.Page}");
                horses.Search(searchParameters).ToList().ForEach(b =>
                {
                    Console.WriteLine($"Common Name: {b.YearWon}");
                });

                searchParameters.Page++;
            }
        }
    }
}