using System;

class triangleOfDollars
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("$");

            for (int a = 0; a < i; a++)
            {
                Console.Write(" $");
            }
            Console.WriteLine();
        }

    }
}

