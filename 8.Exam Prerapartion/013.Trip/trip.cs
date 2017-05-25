using System;


namespace Trip
{
    class trip
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    budget *= 0.3m;
                    string typeHoliday = "Camp";
                    Console.WriteLine($"Somewhere in {destination}\n{typeHoliday} - {budget:0.00}");
                }
                else if (season == "winter")
                {
                    budget *= 0.7m;
                    string typeHoliday = "Hotel";
                    Console.WriteLine($"Somewhere in {destination}\n{typeHoliday} - {budget:0.00}");
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    budget *= 0.4m;
                    string typeHoliday = "Camp";
                    Console.WriteLine($"Somewhere in {destination}\n{typeHoliday} - {budget:0.00}");
                }
                else if (season == "winter")
                {
                    budget *= 0.8m;
                    string typeHoliday = "Hotel";
                    Console.WriteLine($"Somewhere in {destination}\n{typeHoliday} - {budget:0.00}");
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                budget *= 0.9m;
                string typeHoliday = "Hotel";
                Console.WriteLine($"Somewhere in {destination}\n{typeHoliday} - {budget:0.00}");
            }
        }
    }
}
