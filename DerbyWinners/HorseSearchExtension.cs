using System.Collections.Generic;
using System.Linq;

namespace DerbyWinners
{
    public class HorseSearch 
    {
        public string YearWon { get; set; }
        public string Horse { get; set; }
        public string Jockey { get; set; }
        public string Trainer { get; set; }
        public string Owner { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        
    }

    public static class HorseSearchExtension
    {
        public static IEnumerable<Horses> Search(this IEnumerable<Horses> source, HorseSearch search)
        {
            return source.Where(s => search.YearWon == null || s.YearWon.Contains(search.YearWon))
                         .Where(s => search.Horse == null || s.Horse.Contains(search.Horse))
                         .Where(s => search.Jockey == null || s.Jockey.Contains(search.Jockey))
                         .Where(s => search.Trainer == null || s.Trainer.Contains(search.Trainer))
                         .Where(s => search.Owner == null || s.Owner.Contains(search.Owner))
                                                       
                         .Skip(search.Page * search.PageSize)
                         .Take(search.PageSize);
        }
    }
}
