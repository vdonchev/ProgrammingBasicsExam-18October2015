namespace _02.GrandTheftExamo
{
    using System;

    class GrandTheftExamo
    {
        private const int MaxSlapped = 5;

        static void Main(string[] args)
        {
            long slappedThieves = 0;
            long escapedThieves = 0;
            long beersDrunk = 0;

            int attempts = int.Parse(Console.ReadLine());
            for (int i = 0; i < attempts; i++)
            {
                int thieves = int.Parse(Console.ReadLine());
                beersDrunk += int.Parse(Console.ReadLine());

                int result = thieves - MaxSlapped;
                if (result > 0)
                {
                    escapedThieves += result;
                    slappedThieves += MaxSlapped;
                    continue;
                }

                slappedThieves += thieves;
            }

            Console.WriteLine($"{slappedThieves} thieves slapped.");
            Console.WriteLine($"{escapedThieves} thieves escaped.");
            Console.WriteLine($"{beersDrunk / 6} packs, {beersDrunk % 6} bottles.");
        }
    }
}
