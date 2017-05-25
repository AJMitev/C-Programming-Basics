using System;

class butterfly
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char symbol = '*';

        for (int i = 0; i < n - 2; i++)
        {
            if (i % 2 == 0)
            {
                symbol = '*';
            }
            else
            {
                symbol = '-';
            }
            Console.WriteLine("{0}\\ /{0}", new string(symbol, n - 2));
        }

        Console.WriteLine("{0}@{0}", new string(' ', n - 1));
        for (int i = 0; i < n - 2; i++)
        {
            if (i % 2 == 0)
            {
                symbol = '*';
            }
            else
            {
                symbol = '-';
            }
            Console.WriteLine("{0}/ \\{0}", new string(symbol, n - 2));
        }
    }
}