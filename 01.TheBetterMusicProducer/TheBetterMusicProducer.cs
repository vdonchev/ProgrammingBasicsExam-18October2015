namespace _01.TheBetterMusicProducer
{
    using System;

    class TheBetterMusicProducer
    {
        static void Main(string[] args)
        {
            int europeAlbums = int.Parse(Console.ReadLine());
            decimal euro = decimal.Parse(Console.ReadLine());
            int northAmericaAlbums = int.Parse(Console.ReadLine());
            decimal dollars = decimal.Parse(Console.ReadLine());
            int southAmericaAlbums = int.Parse(Console.ReadLine());
            decimal pesos = decimal.Parse(Console.ReadLine());
            int numOfConcerts = int.Parse(Console.ReadLine());
            decimal incomePerConcert = decimal.Parse(Console.ReadLine());

            decimal albumsIncome = CalculateIncomeFromAlbums(europeAlbums, euro, northAmericaAlbums, dollars, southAmericaAlbums, pesos);
            decimal concertsIncome = CalculateIncomeFromConcerts(numOfConcerts, incomePerConcert);

            if (albumsIncome > concertsIncome)
            {
                Console.WriteLine($"Let's record some songs! They'll bring us {albumsIncome:F2}lv.");
            }
            else
            {
                Console.WriteLine($"On the road again! We'll see the world and earn {concertsIncome:F2}lv.");
            }
        }

        private static decimal CalculateIncomeFromConcerts(int numOfConcerts, decimal incomePerConcert)
        {
            incomePerConcert = incomePerConcert * numOfConcerts * 1.94M;
            if (incomePerConcert > 100000)
            {
                incomePerConcert *= .85M;
            }

            return incomePerConcert;
        }

        private static decimal CalculateIncomeFromAlbums(int europeAlbums, decimal euro, int northAmericaAlbums, decimal dollars, int southAmericaAlbums, decimal pesos)
        {
            decimal totalIncome = europeAlbums * euro * 1.94M;
            totalIncome += northAmericaAlbums * dollars * 1.72M;
            totalIncome += southAmericaAlbums * pesos / 332.74M;
            totalIncome *= .65M;
            totalIncome *= .8M;

            return totalIncome;
        }
    }
}
