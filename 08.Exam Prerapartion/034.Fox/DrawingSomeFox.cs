using System;

class DrawingSomeFox
{
    static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());
        int width = n * 2 + 3;
        //Logic
        for (int i = 1; i <=n; i++)
        {
            Console.WriteLine(new string('*',i)+"\\"+new string('-',width-2-i*2)+"/"+ new string('*', i));
        }//endOfTop
        for (int i = 0; i < n/3; i++)
        {
            Console.WriteLine("|"+new string('*',n/2+i)+"\\"+ new string('*', n-2*i)+"/"+ new string('*', n / 2+i)+"|");
        }
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(new string('-', i) + "\\" + new string('*', width - 2 - i * 2) + "/" + new string('-', i));
        }
    }
}

