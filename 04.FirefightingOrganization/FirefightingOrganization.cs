namespace _04.FirefightingOrganization
{
    using System;

    class FirefightingOrganization
    {
        static void Main(string[] args)
        {
            int fireFighters = int.Parse(Console.ReadLine());
            int savedKids = 0;
            int savedAdults = 0;
            int savedSeniors = 0;

            string building;
            while (!(building = Console.ReadLine()).Equals("rain"))
            {
                char[] people = building.Replace("A", "L").ToCharArray();
                Array.Sort(people);

                for (int i = 0; i < Math.Min(people.Length, fireFighters); i++)
                {
                    switch (people[i])
                    {
                        case 'K': savedKids++; break;
                        case 'L': savedAdults++; break;
                        case 'S': savedSeniors++; break;
                    }
                }
            }

            Console.WriteLine($"Kids: {savedKids}\nAdults: {savedAdults}\nSeniors: {savedSeniors}");
        }
    }
}
