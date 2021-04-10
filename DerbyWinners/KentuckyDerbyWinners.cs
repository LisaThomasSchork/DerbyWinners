using System.Collections.Generic;

namespace DerbyWinners
{
    public static class KentuckyDerbyWinners
    {
        public static List<Horses> LoadHorses()
        {
            var utility = new RandomUtility();
            var horses = new List<Horses>
            {

                // YearWon, Horse, Jockey, Trainer, Owner
                new Horses(utility, "2020", "Authentic", "John R. Velazquez", "Bob Baffert", "Spendthrift Farm LLC, MyRaceHorse Stable, Madaket Stables LLC and Starlight Racing"),
                new Horses(utility, "2019", "Country House", "Flavien Prat", "William I. Mott", "Mrs. JV Shields, EJM McFadden and LNJ Foxwoods"),
                new Horses(utility, "2018", "Justify", "Mike E. Smith", "Bob Baffert", "China Horse Club, Head of Plains Partners, Starlight Racing and WinStar Farms"),
                new Horses(utility, "2017", "Always Dreaming", "John R. Velazquez", "Todd Pletcher", "Brooklyn Boyz Stables, Teresa Viola Racing Stables, Siena Farm LLC, West Point Thoroughbreds, MeB Racing Stables LLC, St. Elias Stables, LLC."),
                new Horses(utility, "2016", "Nyquist", "Mario Gutierrez", "Doug F. O'Neill", "Reddam Racing LLC"),
                new Horses(utility, "2015", "American Pharoah", "Victor Espinoza", "Bob Baffert", "Ahmed Zayat"),
                new Horses(utility, "2014", "California Chrome", "Victor Espinoza", "Art Sherman", "Steve and Carolyn Coburn & Perry and Denise Martin"),
                new Horses(utility, "2013", "Orb", "Joel Rosario", "Claude R. Shug McGaughey III", "Stuart Janney III & Phipps Stable "),
                new Horses(utility, "2012", "I'll Have Another", "Mario Gutierrez", "Doug O'Neil", "J. Paul Reddam"),
                new Horses(utility, "2011", "Animal Kingdom", "John Velazquez", "H. Graham Motion", "Team Valor International"),
                new Horses(utility, "2010", "Super Saver", "Calvin Borel", "Todd Pletcher", "WinStar Farm LLC."),
                new Horses(utility, "2009", "Mine That Bird", "Calvin Borel", "Bennie Woolley Jr.", "Double Eagle Ranch & Bueno Suerte Equine"),
                new Horses(utility, "2008", "Big Brown", "Kent Desormeaux", "Richard Dutrow, Jr", "IEAH Stable and Paul P. Pompa Jr."),
                new Horses(utility, "2007", "Street Sense", "Calvin Borel", "Carl Nafzger", "James B. Tafel"),
                new Horses(utility, "2006", "Barbaro", "Edgar Prado", "Michael Matz", "Lael Stables"),
                new Horses(utility, "2005", "Giacomo", "Mike Smith", "John Shirreffs", "Mr. & Mrs. Jerome S. Moss"),
                new Horses(utility, "2004", "Smarty Jones", "Stewart Elliott", "John Servis", "Someday Farm"),
                new Horses(utility, "2003", "Funny Cide", "José Santos", "Barclay Tagg", "Sackatoga Stable"),
                new Horses(utility, "2002", "War Emblem", "Victor Espinoza", "Bob Baffert", "The Thoroughbred Corporation"),
                new Horses(utility, "2001", "Monarchos", "Jorge Chavez", "John T. Ward, Jr.", "John C. Oxley"),
                new Horses(utility, "2000", "Fusaichi Pegasus", "Kent Desormeaux", "Neil D. Drysdale", "Fusao Sekiguchi")
            };

            return horses;
        }
    }
}
