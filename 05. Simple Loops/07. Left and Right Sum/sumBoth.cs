using System;

    class sumBoth
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int leftSum = 0;
        int rightSum = 0;

        for (int i = 0; i < n; i++) //LeftSum
        {
            int number = int.Parse(Console.ReadLine());
            leftSum += number;
        }
        for (int i = 0; i < n; i++) //RightSum
        {
            int number = int.Parse(Console.ReadLine());
            rightSum += number;
        }
        int diff = Math.Abs(leftSum - rightSum);
        if (diff.Equals(0))
        {
            Console.WriteLine($"Yes, sum = {leftSum}");
        }
        else
        {
            Console.WriteLine($"No, diff = {diff}");
        }
    }
}

