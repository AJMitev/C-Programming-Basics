using System;

class SummerTime
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string(' ', n / 2) + new string('*', n + 1) + new string(' ', n / 2));
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(new string(' ', n / 2) + '*' + new string(' ', n - 1) + '*');
        }
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(new string(' ', n / 2 - i) + '*' + new string(' ', n / 2 + n / 2 + 2 * i) + '*');
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine('*' + new string('.', 2 * n - 2) + '*');
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine('*' + new string('@', 2 * n - 2) + '*');
        }
        Console.WriteLine(new string('*', 2 * n));
    }
}
