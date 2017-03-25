using System;

class Program
{
    static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('*', (int)n));
        }
    }
}

