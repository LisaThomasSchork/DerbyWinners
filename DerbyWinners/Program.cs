using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerbyWinners
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var searchParameters = new HorseSearch
            {
                YearWon = "Year",
                V2 = "Winner",
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
                    Console.WriteLine($"Common Name: {b.V1}");
                });

                searchParameters.Page++;
            }
        }
    }
}