using System;

class TimeMachine
{
    static void Main()
    {
        //Input
        decimal money = decimal.Parse(Console.ReadLine());
        int yearToDie = int.Parse(Console.ReadLine());

        //Logic
        int yearsOfIvancho = 17;
        int yearToBorn = 1800;
        for (int i = yearToBorn; i <= yearToDie; i++)
        {
            yearsOfIvancho++;
            if (i % 2 == 0)
            {
                money -= 12000;
            }
            else
            {
                money -= 12000 + (50 * yearsOfIvancho);
            }

        }
        if (money >= 0)
        {
            Console.WriteLine($"Yes! He will live a carefree life and will have {money:0.00} dollars left.");
        }
        else
        {
            Console.WriteLine($"He will need {Math.Abs(money):0.00} dollars to survive.");
        }
    }
}

