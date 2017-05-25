using System;

namespace TomTheCat
{
    class TomTheCat
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());

            int workingDays = 365 - holidays;
            int tomWillPlay = (workingDays * 63) + (holidays * 127);
            int tomSleepNorm = 30000;
            int hoursLeft = Math.Abs(tomSleepNorm - tomWillPlay);

            if (tomWillPlay > tomSleepNorm)
            {
                Console.WriteLine($"Tom will run away\n{hoursLeft/60:0} hours and {hoursLeft%60:00} minutes more for play");
            }
            else if (tomWillPlay <= tomSleepNorm)
            {
                Console.WriteLine($"Tom sleeps well\n{hoursLeft/60:0} hours and {hoursLeft%60:00} minutes less for play");
            }
        }
    }
}
