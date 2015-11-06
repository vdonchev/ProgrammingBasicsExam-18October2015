namespace _03.PlaidTowel
{
    using System;

    class PlaidTowel
    {
        private static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char bg = char.Parse(Console.ReadLine());
            char fg = char.Parse(Console.ReadLine());

            string topBottomPart = new string(bg, size) + fg + new string(bg, size * 2 - 1) + fg + new string(bg, size);
            string middlePart = fg + new string(bg, size * 2 - 1) + fg + new string(bg, size * 2 - 1) + fg;

            Console.WriteLine(topBottomPart);
            BuildDown(size, bg, fg);
            Console.WriteLine(middlePart);
            BuildUp(size, bg, fg);
            Console.WriteLine(topBottomPart);
            BuildDown(size, bg, fg);
            Console.WriteLine(middlePart);
            BuildUp(size, bg, fg);
            Console.WriteLine(topBottomPart);
        }

        private static void BuildDown(int size, char bg, char fg)
        {
            int leftRight = size - 1;
            int middle = size * 2 - 3;
            int sub = 1;

            for (int i = 1; i < size; i++)
            {
                Console.WriteLine(new string(bg, leftRight) + fg + new string(bg, sub) + fg + new string(bg, middle) + fg + new string(bg, sub) + fg + new string(bg, leftRight));
                leftRight--;
                middle -= 2;
                sub += 2;
            }
        }

        private static void BuildUp(int size, char bg, char fg)
        {
            int leftRight = 1;
            int middle = 1;
            int sub = size * 2 - 3;

            for (int i = 1; i < size; i++)
            {
                Console.WriteLine(new string(bg, leftRight) + fg + new string(bg, sub) + fg + new string(bg, middle) + fg + new string(bg, sub) + fg + new string(bg, leftRight));
                leftRight++;
                middle += 2;
                sub -= 2;
            }
        }
    }
}
