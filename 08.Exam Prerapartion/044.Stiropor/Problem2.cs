using System;

class Problem2
{
    static void Main()
    {
        //Input
        double budget = double.Parse(Console.ReadLine());
        double houseArea = double.Parse(Console.ReadLine());
        int windows =  int.Parse(Console.ReadLine());
        double howMuchSteroporPerPakage = double.Parse(Console.ReadLine());
        double coastOfOnePagae = double.Parse(Console.ReadLine());

        //Logic
        double windwsArea = windows * 2.40;
        double realHouseArea = houseArea - windwsArea;
        double afterBrak = realHouseArea * 1.10;
        double howManuPagake = Math.Ceiling(afterBrak / howMuchSteroporPerPakage);
        double pakageCoast = howManuPagake * coastOfOnePagae;
        double result = budget - pakageCoast;


        //Output
        if (result>=0)
        {
            Console.WriteLine($"Spent: {pakageCoast:0.00}\nLeft: {result:0.00}");
        }
        else
        {
            result = Math.Abs(result);
            Console.WriteLine($"Need more: {result:0.00}");
        }
    }
}

