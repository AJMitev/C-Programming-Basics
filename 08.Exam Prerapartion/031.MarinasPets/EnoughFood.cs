using System;
class EnoughFood
{
    static void Main()
    {
        //Input
        int howManyDays = int.Parse(Console.ReadLine());
        int howManyFoods = int.Parse(Console.ReadLine());
        double dogsFood = double.Parse(Console.ReadLine());
        double catsFood = double.Parse(Console.ReadLine());
        double turtlesFood = double.Parse(Console.ReadLine());

        //Logic
        double turtlesFoodInKilos = turtlesFood / 1000;
        double foodEaten = (dogsFood + catsFood + turtlesFoodInKilos)*howManyDays;
        double result = howManyFoods - foodEaten;
        bool isThereEnoughFood = howManyFoods >= foodEaten;

        //Output
        if (isThereEnoughFood)
        {
            Console.WriteLine($"{Math.Floor(result)} kilos of food left.");
        }
        else
        {
            result = Math.Abs(result);
            Console.WriteLine($"{Math.Ceiling(result)} more kilos of food are needed.");
        }
    }
}

