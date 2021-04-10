using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

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
        public string V2 { get; internal set; }
    }

    public static class HorseSearchExtension
    {
        public static IEnumerable<Horses> Search(this IEnumerable<Horses> source, HorseSearch search)
        {
            return source.Where(s => search.YearWon == null || s.V1.Contains(search.YearWon))
                         .Where(s => search.Horse == null || s.V2.Contains(search.Horse))
                         .Where(s => search.Jockey == null || s.V3.Contains(search.Jockey))
                         .Where(s => search.Trainer == null || s.V4.Contains(search.Trainer))
                         .Where(s => search.Owner == null || s.V5.Contains(search.Owner))
                                                       
                         .Skip(search.Page * search.PageSize)
                         .Take(search.PageSize);
        }
    }
}
