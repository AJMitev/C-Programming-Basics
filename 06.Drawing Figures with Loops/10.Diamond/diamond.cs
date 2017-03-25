using System;

class diamond
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int middleDashCnt = 0;
        if (n == 1)
        {
            Console.WriteLine("*");
            return;
        }
        if (n % 2 == 1)
        {
            Console.WriteLine(new string('-', n / 2) + "*" + new string('-', n / 2));
            middleDashCnt++;
        }    

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('-', n / 2 - 1 - i));
            Console.Write("*");
            Console.Write(new string('-', middleDashCnt + 2 * i));
            Console.Write("*");
            Console.WriteLine(new string('-', n / 2 - 1 - i));
        }

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.Write(new string('-', 1 + i));
            Console.Write("*");
            Console.Write(new string('-', n - 4 - 2 * i));
            Console.Write("*");
            Console.WriteLine(new string('-', 1 + i));
        }

        if (n % 2 == 1)
        {
            Console.WriteLine(new string('-', n / 2) + "*" + new string('-', n / 2));
        }

    }
}

