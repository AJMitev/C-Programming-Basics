using System;

class histogram
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int cntr = 0;
        int cntr2 = 0;
        int cntr3 = 0;
        int cntr4 = 0;
        int cntr5 = 0;

        for (int i = 0; i < n; i++)
        {
            int m = int.Parse(Console.ReadLine());
            if (m >= 0 && m < 200)
            {
                cntr++;
            }
            else if (m >= 200 && m <=399)
            {
                cntr2++;
            }
            else if (m >= 400 && m <=599)
            {
                cntr3++;
            }
            else if (m >= 600 && m <=799)
            {
                cntr4++;
            }
            else if (m >= 800)
            {
                cntr5++;
            }

        }

        //To %
        double firstResult = (cntr / (double)n) * 100.00;
        double secondResult = (cntr2 / (double)n) * 100.00;
        double thirdResult = (cntr3 / (double)n) * 100.00;
        double fourthResult = (cntr4 /(double)n) * 100.00;
        double fifthResult = (cntr5 / (double)n) * 100.00;

        Console.WriteLine($"{firstResult:0.00}%\n{secondResult:0.00}%\n{thirdResult:0.00}%\n{fourthResult:0.00}%\n{fifthResult:0.00}%");
    }
}

