using System;

class squareFrame
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());


        Console.Write("+");
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(" -");
        }
        Console.WriteLine(" +");
                                 // Inside
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("|");
            for (int a = 0; a < n - 2; a++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" |");
        }
        //Last Row
        Console.Write("+");
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(" -");
        }
        Console.WriteLine(" +");
    }
}

