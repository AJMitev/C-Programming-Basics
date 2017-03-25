using System;

class sunglasses
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('*', n * 2) + new string(' ', n) + new string('*', n * 2));
        char specialSimbyl = ' ';
        for (int i = 0; i < n-2; i++)
        {
            if (i == (n-1)/2-1)
            {
                specialSimbyl = '|';
            }
            Console.Write("*" + new string('/',n*2-2)+"*");
            Console.Write(new string(specialSimbyl,n));
            Console.WriteLine("*" + new string('/', n * 2 - 2) + "*");
            specialSimbyl = ' ';
        }
        Console.WriteLine(new string('*', n * 2) + new string(' ', n) + new string('*', n * 2));

    }
}

