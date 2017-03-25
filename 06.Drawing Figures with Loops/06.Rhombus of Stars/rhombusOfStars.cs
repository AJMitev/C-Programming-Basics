using System;

class rhombusOfStars
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        //first half
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string(' ', n - 1 - i));
            Console.Write("*");
            for (int a = 0; a < i; a++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
        //Second Half
        for (int i = 0; i < n-1; i++)
        {
            Console.Write(new string(' ', 1 + i ));
            Console.Write("*");
            for (int a = 0; a < n-2-i; a++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
    }
}
