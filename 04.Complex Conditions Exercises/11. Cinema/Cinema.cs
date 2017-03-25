using System;

    class Cinema
{
    static void Main(string[] args)
    {
        string typeTicket = Console.ReadLine().ToLower();
        int rows = int.Parse(Console.ReadLine());
        int colons = int.Parse(Console.ReadLine());
        double ticketPrice = 0;

        if (typeTicket == "premiere")
        {
            ticketPrice = 12.00;
            double expectedProfit = (rows * colons) * ticketPrice;
            Console.WriteLine($"{expectedProfit:0.00} leva");
        }
        else if (typeTicket == "normal")
        {
            ticketPrice = 7.50;
            double expectedProfit = (rows * colons) * ticketPrice;
            Console.WriteLine($"{expectedProfit:0.00} leva");
        }
        else if (typeTicket == "discount")
        {
            ticketPrice = 5.00;
            double expectedProfit = (rows * colons) * ticketPrice;
            Console.WriteLine($"{expectedProfit:0.00} leva");
        }
        else
        {
            Console.WriteLine("unknown ticket type");
        }

    }
}

