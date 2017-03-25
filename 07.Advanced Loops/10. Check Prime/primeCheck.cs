using System;

class primeCheck
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        bool isPrime = true;
        if (n < 2)
        {
            Console.WriteLine("Not prime");

        }
        else
        {

       

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Not prime");
        }
        }
    }
}

