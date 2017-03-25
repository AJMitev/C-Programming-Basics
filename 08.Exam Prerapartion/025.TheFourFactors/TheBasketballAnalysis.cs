using System;

class TheBasketballAnalysis
{
    static void Main()
    {
        try
        {
            //Input
            uint fieldGoals = uint.Parse(Console.ReadLine());
            uint fieldGoalAttempts = uint.Parse(Console.ReadLine());
            uint threePointsFieldGoals = uint.Parse(Console.ReadLine());
            uint turnovers = uint.Parse(Console.ReadLine());
            uint offensiveRebounds = uint.Parse(Console.ReadLine());
            uint oponentDefensiveRebounds = uint.Parse(Console.ReadLine());
            uint freeThrows = uint.Parse(Console.ReadLine());
            uint freeThrowAttempts = uint.Parse(Console.ReadLine());

            //Logic
            double efgPercent = ((double)fieldGoals + 0.5 * threePointsFieldGoals) / fieldGoalAttempts;
            double tovPercent = turnovers / ((double)fieldGoalAttempts + 0.44 * freeThrowAttempts + turnovers);
            double orbPercent = (double)offensiveRebounds / (offensiveRebounds + oponentDefensiveRebounds);
            double ftPercent = (double)freeThrows / fieldGoalAttempts;
            //Output
            Console.WriteLine($"eFG% {efgPercent:0.000} ");
            Console.WriteLine($"TOV% {tovPercent:0.000}");
            Console.WriteLine($"ORB% {orbPercent:0.000}");
            Console.WriteLine($"FT% {ftPercent:0.000}");

        }
        catch (Exception)
        {

            Console.WriteLine("Enter a Possitive Number!");
        }
    }
}

