using System;

class drawFort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int row = n / 2;
        int centerLine = (n * 2) - ((n/2)*2 +4);
        int wight = 2 * n;

        //FirstLane
        Console.WriteLine("/" + new string('^', row) + "\\" + new string('_', centerLine)+ "/" + new string('^', row) + "\\");

        //MiddleLane
        for (int i = 0; i < n-3; i++)
        {
            Console.WriteLine("|" + new string(' ',wight-2)+"|");
        }

        //BottomLane
        Console.WriteLine("|" + new string(' ', row) + " " + new string('_', centerLine) + " " + new string(' ', row) + "|");
        Console.WriteLine("\\" + new string('_', row) + "/" + new string(' ', centerLine) + "\\" + new string('_', row) + "/");
    }
}

