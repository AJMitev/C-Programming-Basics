using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int cntr = 0;
        int cntr2 = 0;
        int cntr3 = 0;


        for (int i = 0; i < n; i++)
        {
            int m = int.Parse(Console.ReadLine());
            if (m % 2 == 0)
            {
                cntr++;
            }
            if (m % 3 == 0)
            {
                cntr2++;
            }
            if (m % 4 == 0)
            {
                cntr3++;
            }

        }

        //To %
        double firstResult = (cntr / (double)n) * 100.00;
        double secondResult = ((double)cntr2 / n) * 100.00;
        double thirdResult = ((double)cntr3 / n) * 100.00;


        Console.WriteLine($"{firstResult:0.00}%\n{secondResult:0.00}%\n{thirdResult:0.00}%");
    }
}

