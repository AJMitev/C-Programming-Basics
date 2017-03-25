using System;

class NetIncome
{
    static void Main()
    {
        //Input
        string season = Console.ReadLine();
        double kilometersPerMonth = double.Parse(Console.ReadLine());

        //Logic
        double kilomeetersInLeva = 0;
        switch (season)
        {
            case "Spring":
                if (kilometersPerMonth >9&& kilometersPerMonth <= 5000)
                {
                    kilomeetersInLeva = 0.75;
                }
                else if (kilometersPerMonth >5000 && kilometersPerMonth <= 10000)
                {
                    kilomeetersInLeva = 0.95;
                }
                else if (kilometersPerMonth >10000 && kilometersPerMonth <=20000)
                {
                    kilomeetersInLeva = 1.45;
                }
                break;
            case "Summer":
                if (kilometersPerMonth > 9 && kilometersPerMonth <= 5000)
                {
                    kilomeetersInLeva = 0.90;
                }
                else if (kilometersPerMonth > 5000 && kilometersPerMonth <= 10000)
                {
                    kilomeetersInLeva = 1.10;
                }
                else if (kilometersPerMonth > 10000 && kilometersPerMonth <= 20000)
                {
                    kilomeetersInLeva = 1.45;
                }
                break;
            case "Autumn":
                if (kilometersPerMonth > 9 && kilometersPerMonth <= 5000)
                {
                    kilomeetersInLeva = 0.75;
                }
                else if (kilometersPerMonth > 5000 && kilometersPerMonth <= 10000)
                {
                    kilomeetersInLeva = 0.95;
                }
                else if (kilometersPerMonth > 10000 && kilometersPerMonth <= 20000)
                {
                    kilomeetersInLeva = 1.45;
                }
                break;
            case "Winter":
                if (kilometersPerMonth > 9 && kilometersPerMonth <= 5000)
                {
                    kilomeetersInLeva = 1.05;
                }
                else if (kilometersPerMonth > 5000 && kilometersPerMonth <= 10000)
                {
                    kilomeetersInLeva = 1.25;
                }
                else if (kilometersPerMonth > 10000 && kilometersPerMonth <= 20000)
                {
                    kilomeetersInLeva = 1.45;
                }
                break;
            default:
                Console.WriteLine("No Such Season!");
                break;
        }
        double salary = (kilometersPerMonth * kilomeetersInLeva)*4;
        double taxes = salary * 0.10;
        double result = salary - taxes;

        //Output
        Console.WriteLine($"{result:0.00}");

    }
}

