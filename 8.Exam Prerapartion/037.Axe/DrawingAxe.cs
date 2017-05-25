using System;

class DrawingAxe
{
    static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());

        //Logic
        int width = n * 5;
        int cntr2 = 0;
        int special = 0;
        int special2 = 0;

        if (n%2==0)
        {
            special = (n * 2) - 1;
            special2 = (n / 2 + 1);
        }
        else
        {
            special = (n * 2) - 2;
            special2 = (n / 2)+2;
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('-', n * 3) +"*" +new string('-',i)+"*"+ new string('-', n*2-2-i));
        }
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine(new string('*', n * 3) + "*" + new string('-', n-1) + "*" + new string('-',n-1));
        }
        for (int i = 0; i < n/2-1; i++)
        {
            
            Console.WriteLine(new string('-', n * 3-i) + "*" + new string('-', n-1+cntr2) + "*" + new string('-', n-1-i));
            cntr2 += 2;

        }

        Console.WriteLine(new string('-', (n * 3) - (n / 2 - 1)) + new string('*', special) + new string('-', n * 3 - special - special2));
    }
}

