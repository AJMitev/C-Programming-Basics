using System;

class DrawingDiamond
{
    static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());

        //Logic
        int width = 5 * n;
        int cntr1 = 0;
        Console.WriteLine(new string('.', n) + new string('*', n * 3) + new string('.', n));
        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine(new string('.',n-1-i)+"*"+new string('.',n*3+i*2)+"*" +new string('.', n-1-i));
        }
        Console.WriteLine(new string('*',width));
        for (int i = 0; i < n*2; i++)
        {
            Console.WriteLine(new string('.',i+1)+"*"+new string('.',width-4-i*2)+"*"+ new string('.', i + 1));
        }
        Console.WriteLine(new string('.', width/2-(n/2)+1) + "*" + new string('*', width - 4 -( (n * 2)*2)) + "*" + new string('.', width / 2 - (n / 2)+1));
    }
}

