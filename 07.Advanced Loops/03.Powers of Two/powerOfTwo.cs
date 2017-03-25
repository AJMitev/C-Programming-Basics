using System;

class powerOfTwo
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 1;

        for (int i = 0; i < n+1 ; i++)
        {
            
            Console.WriteLine(sum);
            sum *= 2;
        }
    }
}

