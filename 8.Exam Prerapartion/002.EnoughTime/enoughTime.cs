using System;

namespace EnoughTime
{
    class enoughTime
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int daysForWork = int.Parse(Console.ReadLine());
            int emploeesWorkOverTime = int.Parse(Console.ReadLine());

            double educatingDays = daysForWork * 0.10;
            double workingDays = (daysForWork - educatingDays) * 8;;
            int overTime = (emploeesWorkOverTime * 2) * daysForWork;;
            double finalResult = Math.Floor(workingDays + overTime);
            double notEnoughTime = Math.Floor(hoursNeeded - finalResult);
            double enoughTime = Math.Floor(finalResult - hoursNeeded);
           

            if (finalResult >= hoursNeeded)
            {
                Console.WriteLine($"Yes!{enoughTime} hours left.");
            }
            else if (finalResult < hoursNeeded)
            {
                Console.WriteLine($"Not enough time!{notEnoughTime} hours needed.");
            }
        }
    }
}
