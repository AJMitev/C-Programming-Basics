using System;

class factoriel
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int factorial = 1;

        for (int i = 1; i < n + 1; i++)
        {

            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}

