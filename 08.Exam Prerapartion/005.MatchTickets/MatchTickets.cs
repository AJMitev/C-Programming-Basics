using System;

    class MatchTickets
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double transport = 0;

            if (people > 0 && people <= 4)
            {
                transport = budget * 0.75;
            }
            else if (people > 4 && people <= 9)
            {
                transport = budget * 0.60;
            }
            else if (people > 9 && people <= 24)
            {
                transport = budget * 0.50;
            }
            else if (people > 24 && people <= 49)
            {
                transport = budget * 0.40;
            }
            else if (people > 50)
            {
                transport = budget * 0.25;
            }
            double moneyLeft = budget - transport;
            if (ticketType.ToLower() == "normal")
            {
                double ticketCoast = 249.99;
                double result = Math.Round(moneyLeft - (ticketCoast * people),2);
                if (result >= 0)
                {
                    Console.WriteLine($"Yes! You have {result:0.00} leva left.");
                }
                else if (result <0)
                {
                    Console.WriteLine($"Not enough money! You need {Math.Abs(result):0.00}  leva.");
                }
            }
            else if (ticketType.ToLower() == "vip")
            {
                double ticketCoast = 499.99;
                double result = Math.Round(moneyLeft - (ticketCoast * people), 2);
                if (result >= 0)
                {
                    Console.WriteLine($"Yes! You have {result:0.00} leva left.");
                }
                else if (result < 0)
                {
                    Console.WriteLine($"Not enough money! You need {Math.Abs(result):0.00} leva.");
                }
            }
        }
    }