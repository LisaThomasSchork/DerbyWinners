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
                YearWon = null,
                Horse = null,
                Jockey = null,
                Trainer = null,
                Owner = null,
                Page = 1,
                PageSize = 5
            };

            Console.WriteLine("Type any key to see a list of Derby Winners");
            var horses = KentuckyDerbyWinners.LoadHorses();

            while (Console.ReadKey().KeyChar != 'q')
            {
                Console.WriteLine($"Page: {searchParameters.Page}");
                horses.Search(searchParameters).ToList().ForEach(s =>
                {
                    Console.WriteLine(s);
                });

                searchParameters.Page++;
            }
        }
    }
}