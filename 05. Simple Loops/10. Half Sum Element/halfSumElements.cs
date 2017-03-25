using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int maxNumber = 0;
        int assembly = 0;

        for (int i = 0; i < n; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());
            if (currentNum > maxNumber)
            {
                maxNumber = currentNum;
            }

            assembly += currentNum;
        }
        int result = Math.Abs(maxNumber - assembly);
        int diff = Math.Abs(maxNumber - result);
        if (maxNumber.Equals(result))
        {
            Console.WriteLine($"Yes, sum {result}");
        }
        else
        {
            Console.WriteLine($"No, diff = {diff}");
        }
    }
}

