using System;

    class Problem4
    {
        static void Main()
        {
        //Input
        int mounts = int.Parse(Console.ReadLine());

        //Logic
        double electricity = 0.0;
        double water = 20;
        double net = 15;
        double others = 0;
        for (int i = 0; i < mounts; i++)
        {
            double amountSpentForElectricity = double.Parse(Console.ReadLine());
            electricity += amountSpentForElectricity;
            others += (amountSpentForElectricity + water + net) * 1.20;
        }
        double result = electricity + (water*mounts) + (net*mounts)+others;
        double total = result / mounts;
        water *= mounts;
        net *= mounts;

        //Output
        Console.WriteLine($"Electricity: {electricity:0.00} lv\nWater: {water:0.00} lv\nInternet: {net:0.00} lv\nOther: {others:0.00} lv\nAverage: {total:0.00} lv");

        }
    }

