using System;

    class Problem5
    {
        static void Main()
        {
            //Input
            int n = int.Parse(Console.ReadLine());

            //Logic
            int high = 4 * n + 4;
            int width = 3 * n + 1;

            Console.WriteLine("+" + new string('~', n - 2) + "+" + new string('.',n*2+1));
            for (int i = 0; i < n*2+1; i++)
            {
                Console.WriteLine("|"+new string('.',i)+"\\"+ new string('~', n - 2) + "\\"+ new string('.', n * 2-i));
            }
            for (int i = 0; i < n * 2 + 1; i++)
            {
                Console.WriteLine(new string('.',i)+"\\"+new string('.',n*2-i)+"|" + new string('~', n - 2) + "|");
            }
            Console.WriteLine(new string('.', n * 2 + 1)+"+" + new string('~', n - 2) + "+");
        }
    }
