using System;

class loopByThree
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i < n + 1; i += 3)
        {
            Console.WriteLine(i);
        }
    }
}

