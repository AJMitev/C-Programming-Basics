using System;

class SumingDigits
{
    static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());

        //Logic
        int hundreds = n / 100;
        int lens = (n % 100) / 10;
        int ones = n % 10;

        int rows = hundreds + lens;
        int numbersPerRow = hundreds + ones;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < numbersPerRow; j++)
            {
                if (n % 5 ==0)
                {
                    n -= hundreds;

                }
                else if (n % 3 ==0)
                {
                    n -= lens;
                }
                else
                {
                    n += ones;
                }
                Console.Write(n+" ");
            }
            Console.WriteLine();

        }
    }
}
