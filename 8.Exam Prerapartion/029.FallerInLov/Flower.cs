using System;

class Flower
{
    static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());

        //Logic
        Console.WriteLine("##" + new string('.',n*2)+ "##" + new string('.', n * 2)+ "##"); // first Static Line
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine("#"+new string('~',i)+ "#"+new string('.',n*2-(i*2))+"#" + new string('.', i*2)+"#"+ new string('.', n * 2 - (i * 2))+"#" + new string('~', i)+"#");
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('.',1+2*i)+"#"+new string('~',n-i)+"#"+new string('.',n*2-(i*2))+"#" + new string('~', n - i)+"#"+ new string('.', 1 + 2 * i));
        }
        Console.WriteLine(new string('.', n * 2+1) + "####" + new string('.', n *2+1)); //middle static Line
        //Last
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('.',n*2+2)+"##"+ new string('.', n * 2+2));
        }
    }
}
