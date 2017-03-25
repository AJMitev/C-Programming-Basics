using System;

class minNumber
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int result = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < result)
            {
                result = number;
            }
        }
        Console.WriteLine(result);
    }
}

