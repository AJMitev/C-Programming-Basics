using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int evenNum = 0;
        int oddNum = 0;

        for (int i = 1; i <= n; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                evenNum += currentNum;
            }
            else
            {
                oddNum += currentNum;
            }
        }
        int diff = Math.Abs(evenNum -oddNum);
        if (diff.Equals(0))
        {
            Console.WriteLine($"Yes, sum = {evenNum}");
        }
        else
        {
            Console.WriteLine($"No, diff = {diff}");
        }
    }
}

