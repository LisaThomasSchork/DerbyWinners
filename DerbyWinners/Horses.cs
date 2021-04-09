using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerbyWinners
{
    public class Horses
    {
        public RandomUtility Utility { get; }
        public string V1 { get; set; }
        public string V2 { get; set; }
        public string V3 { get; set; }
        public string V4 { get; set; }
        public string V5 { get; set; }
        public object RandomUtility { get; internal set; }

        public override string ToString()
        {
            return string.Format("Name: {0}\n", V1);
        }

        public Horses(RandomUtility utility, string YearWon, string Horse, string Jockey, string Trainer, string Owner)
        {
            Utility = utility;
            V1 = YearWon;
            V2 = Horse;
            V3 = Jockey;
            V4 = Trainer;
            V5 = Owner;
        }


    }
}
