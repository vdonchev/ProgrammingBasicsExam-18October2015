namespace _05.BohemchoTheBadGhost
{
    using System;
    using System.Linq;

    class BohemchoTheBadGhost
    {
        static void Main(string[] args)
        {
            int lightsOn = 0;
            long score = 0;

            string command;
            while (!(command = Console.ReadLine()).Equals("Stop, God damn it"))
            {
                long floorState = long.Parse(command);
                int[] apartaments = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                foreach (int ap in apartaments)
                {
                    floorState ^= 1L << ap;
                }

                for (int i = 0; i < 32; i++)
                {
                    if (((floorState >> i) & 1L) == 1)
                    {
                        lightsOn++;
                    }
                }

                score += floorState;
            }

            Console.WriteLine($"Bohemcho left {lightsOn} lights on and his score is {score }");
        }
    }
}
