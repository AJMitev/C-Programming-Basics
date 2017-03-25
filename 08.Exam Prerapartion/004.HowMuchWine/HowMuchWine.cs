using System;

namespace HowMuchWine
{
    class HowMuchWine
    {
        static void Main(string[] args)
        {
            int howLongIsVineyard = int.Parse(Console.ReadLine());
            double grapesPerKilometer = double.Parse(Console.ReadLine());
            int litersVineNeeded = int.Parse(Console.ReadLine());
            int empleyees = int.Parse(Console.ReadLine());

            double howMuchGoesToWine = howLongIsVineyard * 0.40;
            double literVine = (howMuchGoesToWine * grapesPerKilometer) / 2.5;
            double quantityOfVine = Math.Abs(litersVineNeeded - literVine);
            if (literVine < litersVineNeeded)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(quantityOfVine)} liters wine needed.");
            }
            else if (literVine >= litersVineNeeded)
            {
                double litersPerEmployee = Math.Ceiling(quantityOfVine / empleyees);
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(literVine)} liters.\n{Math.Ceiling(quantityOfVine)} liters left -> {Math.Ceiling(litersPerEmployee)} liters per person.");
            }
        }
    }
}
