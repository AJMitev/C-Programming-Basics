using System;

class oddOrEvenPosition
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        double evenMin = double.MaxValue;
        double evenMax = double.MinValue;
        double evenSum = 0;
        double oddSum = 0;
        double oddMin = double.MaxValue;
        double oddMax = double.MinValue;

        for (int i = 1; i <= n; i++)
        {
            double currentNum = double.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                evenSum += currentNum;
            }
            else
            {
                oddSum += currentNum;
            }
            if (i % 2 == 0)
            {
                if (evenMax < currentNum)
                {
                    evenMax = currentNum;
                }
               if (evenMin > currentNum)
                {
                    evenMin = currentNum;
                }
            }
            else
            {
                if (oddMax < currentNum)
                {
                    oddMax = currentNum;
                }
                if (oddMin > currentNum)
                {
                    oddMin = currentNum;
                } 
            }
        }
        Console.WriteLine($"OddSum={oddSum},");  /*\/*n\nEvenMin ={ evenMin},\nEvenMax ={ evenMax}*/
        if (oddMin == double.MaxValue)
        {
            Console.WriteLine($"OddMin=no,");
        }
        else
        {
            Console.WriteLine($"OddMin ={oddMin},");
        }
        if (oddMax == double.MinValue)
        {
            Console.WriteLine($"OddMax=no,");
        }
        else
        {
            Console.WriteLine($"OddMax ={oddMax},");
        }
        Console.WriteLine($"EvenSum ={evenSum},");
        if (evenMin == double.MaxValue)
        {
            Console.WriteLine($"EvenMin=no,");
        }
        else
        {
            Console.WriteLine($"EvenMin ={evenMin},");
        }
        if (evenMax == double.MinValue)
        {
            Console.WriteLine($"EvenMax=No");
        }
        else
        {
            Console.WriteLine($"EvenMax ={evenMax}");
        }
    }
}
