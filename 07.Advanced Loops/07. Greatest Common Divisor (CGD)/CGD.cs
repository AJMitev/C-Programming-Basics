using System;

class CGD
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        while (b != 0)
        {
            int temp = a;
            a = b;
            b = temp % b;
        }
        Console.WriteLine(a);
    }
}
