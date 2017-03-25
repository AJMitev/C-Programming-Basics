using System;

class CountingProgram
{
    static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());

        //Logic
        int groupSize = 0;
        int peopleWithCars = 0;
        int peopleWithVan = 0;
        int peopleWithSmallBuss = 0;
        int peopleWithBuss = 0;
        int peopleWithTrain = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            groupSize += number;
            if (number > 0 && number < 6)
            {
                peopleWithCars += number;
            }
            else if (number > 5 && number <= 12)
            {
                peopleWithVan += number;
            }
            else if (number > 12 && number <= 25)
            {
                peopleWithSmallBuss += number;
            }
            else if (number > 25 && number <= 40)
            {
                peopleWithBuss += number;
            }
            else if (number > 40)
            {
                peopleWithTrain += number;
            }

        }

        //Output
        double resultPeopleWithCars = (peopleWithCars / (double)groupSize) * 100;
        double resultPeopleWithVan = (peopleWithVan / (double)groupSize) * 100;
        double resultPeopleWithSmallBuss = (peopleWithSmallBuss / (double)groupSize) * 100;
        double resultPeopleWithBuss = (peopleWithBuss / (double)groupSize) * 100;
        double resultPeopleWithTrain = (peopleWithTrain / (double)groupSize) * 100;
        Console.WriteLine($"{resultPeopleWithCars:0.00}%");
        Console.WriteLine($"{resultPeopleWithVan:0.00}%");
        Console.WriteLine($"{resultPeopleWithSmallBuss:0.00}%");
        Console.WriteLine($"{resultPeopleWithBuss:0.00}%");
        Console.WriteLine($"{resultPeopleWithTrain:0.00}%");

    }
}

