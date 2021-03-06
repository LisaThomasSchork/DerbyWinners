using System;
using System.Collections.Generic;

namespace DerbyWinners
{
    public class RandomUtility
    {
        private readonly Random gen = new Random();


        public List<Horses> AddRandomHorses(int count)
        {
            var horses = new List<Horses>();
            for (int i = 0; i < count; i++)
            {
                horses.Add(new Horses(this, YearWon(), Horses(), Jockey(), Trainer(), Owner()));

            }
            return horses;
        }
        public string YearWon()
        {
            string[] YearWon = { "2000", "2002", "2004", "2006", "2008", "2010", "2012", "2014", "2016" };
            int range = YearWon.Length;
            return YearWon[gen.Next(range)];
        }

        public string Horses()
        {
            string[] Horses = { "Hall", "Jones", "Harrison", "King", "Taylor", "Stone", "Collins", "Gardner", "Reeves", "Holt", "Baker" };
            int range = Horses.Length;
            return Horses[gen.Next(range)];
        }
        public string Jockey()
        {
            string[] Jockey = { "Authentic", "Country House", "Justify", "Always Dreaming", "Nyquist", "American Pharoah", "California Chrome", "Orb", "I'll Have Another" };
            int range = Jockey.Length;
            return Jockey[gen.Next(range)];
        }

        public string Trainer()
        {
            string[] Trainer = { "John R. Velazquez", "Flavien Prat", "Mike E. Smith", "John R. Velazquez", "Mario Gutierrez", "Victor Espinoza", "Victor Espinoza", "Claude R. Shug McGaughey III", "Mario Gutierrez", "John Velazquez", "Calvin Borel" };
            int range = Trainer.Length;
            return Trainer[gen.Next(range)];
        }
        public string Owner()
        {
            string[] Owner = { "Bob Baffert", "William I. Mott", "Bob Baffert", "Todd Pletcher", "Doug F. O'Neill", "Bob Baffert", "Art Sherman", "Stuart Janney III & Phipps Stable ", "Reeves", "H. Graham Motion", "Todd Pletcher" };
            int range = Owner.Length;
            return Owner[gen.Next(range)];
        }
    }
}
