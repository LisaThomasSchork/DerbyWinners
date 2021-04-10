namespace DerbyWinners
{
    public class Horses
    {
        public RandomUtility Utility { get; }
        public string YearWon { get; set; }
        public string Horse { get; set; }
        public string Jockey { get; set; }
        public string Trainer { get; set; }
        public string Owner { get; set; }
        public object RandomUtility { get; internal set; }

        public override string ToString()
        {
            return string.Format("Name: {0}\n", YearWon);
        }

        public Horses(RandomUtility utility, string yearWon, string horse, string jockey, string trainer, string owner)
        {
            Utility = utility;
            YearWon = yearWon;
            Horse = horse;
            Jockey = jockey;
            Trainer = trainer;
            Owner = owner;
        }


    }
}
