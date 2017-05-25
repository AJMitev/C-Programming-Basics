using System;

namespace DailyIncome
{
    class DailyIncome
    {
        static void Main(string[] args)
        {
            int workDays = int.Parse(Console.ReadLine());
            double dailyProfit = double.Parse(Console.ReadLine());
            double exchangeRate = double.Parse(Console.ReadLine());

            if (workDays >= 5 && workDays <= 30)
            {
                if (dailyProfit >= 10.00 && dailyProfit <= 2000.00)
                {
                    if (exchangeRate >= 0.99 && exchangeRate <= 1.99)
                    {
                        double mounthSalary = workDays * dailyProfit;
                        double yearlySalary = (mounthSalary * 12) + (mounthSalary * 2.5);
                        double tax = yearlySalary * 0.25;
                        double netWinnings = (yearlySalary - tax) * exchangeRate;
                        double dailyNetWinnings = netWinnings / 365;
                        Console.WriteLine(Math.Round(dailyNetWinnings, 2));
                    }
                    else Console.WriteLine("Work days can be between 5 and 30");
                }
                else Console.WriteLine("Daily Profit can be btween $10 and $2000");
            }
            else Console.WriteLine("US Dollars course can be a number between $0.99 and $1.99");
            
        }
    }
}
