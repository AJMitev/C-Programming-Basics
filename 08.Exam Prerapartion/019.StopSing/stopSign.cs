using System;

class stopSign
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = 0;

        //FirstLine
        Console.WriteLine(new string('.',n+1)+ new string('_',n*2+1)+ new string('.', n + 1));

        //bottom
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('.',n-i)+new string('/',2)+ new string('_',n*2-1+i*2) + new string('\\', 2)+ new string('.', n - i)); //15
            a = i;
        }
        //sign
        Console.WriteLine("//"+ new string('_',a*2-1)+"STOP!"+ new string('_', a*2-1)+"\\\\");
        Console.WriteLine("\\\\" + new string('_', a * 2 - 1+5) + new string('_', a * 2 - 1) + "//");

        //bott
        for (int i = a; i > 0; i--)
        {
            Console.WriteLine(new string('.', n - i) + new string('\\', 2) + new string('_', n * 2 - 1 + i * 2) + new string('/', 2) + new string('.', n - i));
        }   
    }
}

