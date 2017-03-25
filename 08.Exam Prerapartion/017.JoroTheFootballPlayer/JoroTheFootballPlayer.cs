using System;

namespace JoroTheFootballPlayer
{
    class Program
    {
        static void Main()
        {
            string year = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int hometown = int.Parse(Console.ReadLine());
            double normalWeekend = (52 - hometown) * 0.66;
            double hometownWeekends = hometown * 2;
            double holidaysPlay = holidays * 0.5;
            double result = normalWeekend + hometown + holidaysPlay;
            if (year == "t")
            {
                result += 3;
                Console.WriteLine(Math.Round(result));
            }
            else
            {
                Console.WriteLine(Math.Round(result));
            }
        }
    }
}
