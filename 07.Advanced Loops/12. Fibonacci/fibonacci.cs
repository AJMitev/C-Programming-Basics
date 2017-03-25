using System;

class fibonacci
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int f0 = 1;
        int f1 = 1;

        for (int i = 1; i < n; i++)
        {
            int nextF = f0 + f1;
            f0 = f1;
            f1 = nextF;
        }
        Console.WriteLine(f1);
    }
}

