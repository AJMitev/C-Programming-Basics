using System;

class TripCalculation
{
    static void Main()
    {
        //Input
        int adults = int.Parse(Console.ReadLine());
        int students = int.Parse(Console.ReadLine());
        int nights = int.Parse(Console.ReadLine());
        string transportType = Console.ReadLine();

        //Logic
        double nightCoast = 82.99 * nights;
        double ticketCoast = 0.0;
        int people = adults + students;
        switch (transportType)
        {
            case "train":
                ticketCoast = adults * 24.99 + students * 14.99;
                break;
            case "bus":
                ticketCoast = adults * 32.50+ students * 28.50;
                break;
            case "boat":
               ticketCoast = adults * 42.99+ students * 39.99;
                break;
            case "airplane":
                ticketCoast = adults * 70.00+students * 50.00;
                break;
            default:
                Console.WriteLine("No such Transport Type!");
                break;
        }
        if (transportType == "train" && people >= 50)
        {
            ticketCoast /= 2;
        }
        ticketCoast *= 2; // Two Directions Transport
        double sum = ticketCoast + nightCoast;
        double firmComission = sum * 0.10;
        double result = sum + firmComission;
        //Output
        Console.WriteLine($"{result:0.00}");
    }
}
