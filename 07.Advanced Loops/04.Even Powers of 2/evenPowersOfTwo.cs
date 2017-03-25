using System;

class evenPowersOfTwo
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 1;

        for (int i = 0; i <= n / 2; i++)
        {

            Console.WriteLine(sum);
            sum *= 4;
        }
    }
}

