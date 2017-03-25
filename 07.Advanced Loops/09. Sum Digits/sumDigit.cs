using System;

class sumDigit
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        do
        {
            int digit = n % 10;
            n = n / 10;
            sum += digit;
        } while (n > 0);
        Console.WriteLine(sum);
    }
}

