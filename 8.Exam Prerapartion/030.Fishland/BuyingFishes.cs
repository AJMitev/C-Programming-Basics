using System;

class BuyingFishes
{
    static void Main()
    {
        //Input
        double mackerelPrice = double.Parse(Console.ReadLine());
        double spratPrice = double.Parse(Console.ReadLine());
        double palamudQuantity = double.Parse(Console.ReadLine());
        double safridQuantity = double.Parse(Console.ReadLine());
        int clamsQuantity = int.Parse(Console.ReadLine());

        //Logic
        double palamudPrice = (mackerelPrice * 1.6) * palamudQuantity;
        double safridPrice = (spratPrice * 1.8) * safridQuantity;
        double clamsPrice = clamsQuantity * 7.5;
        double result = palamudPrice + safridPrice + clamsPrice;

        //Output
        Console.WriteLine($"{result:0.00}");

    }
}
