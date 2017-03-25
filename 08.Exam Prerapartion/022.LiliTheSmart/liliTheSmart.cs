using System;

class liliTheSmart
{
    static void Main(string[] args)
    {
        int age = int.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        int toyPrice = int.Parse(Console.ReadLine());

        int moneyFromBirthdays = 0;
        int moneyFromToys = 0;
        int cntr = 0;

        for (int i = 1; i <=age; i++)
        {
            if (i % 2 == 0)
            {
                cntr++;
                moneyFromBirthdays += (cntr*10);
            }
            else
            {
                moneyFromToys += toyPrice;
            }
        }
        double totalMoney = (moneyFromBirthdays + moneyFromToys) - (cntr);
        double result = totalMoney - price;
        if (result >= 0)
        {
            Console.WriteLine($"Yes! {result:0.00}");
        }
        else
        {
            Console.WriteLine($"No! {Math.Abs(result):0.00}");
        }
    }
}

