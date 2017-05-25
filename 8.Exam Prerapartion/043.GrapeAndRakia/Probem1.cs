using System;

class Probem1
{
    static void Main()
    {
        //Input

        double groundArea = double.Parse(Console.ReadLine());
        double productionOfOneSqareArea = double.Parse(Console.ReadLine());
        double brak = double.Parse(Console.ReadLine());

        //Logic
        double howMuchGrapes = groundArea * productionOfOneSqareArea;
        double netResult = howMuchGrapes - brak;
        double howMuchForRakia = netResult * 0.45;
        double litersRakia = howMuchForRakia / 7.5;
        double incomeOfRakia = litersRakia * 9.80;
        double howMuchForSelling = netResult * 0.55;
        double incomeOfSellingGrapes = howMuchForSelling * 1.5;

        //Output
        Console.WriteLine($"{incomeOfRakia:0.00}\n{incomeOfSellingGrapes:0.00} ");
    }
}

