using System;

    class BreackingNumber
    {
        static void Main()
        {
            //Input
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            //Logic
            for (int i = m; i >= n; i--)
            {
                if (i % 3 == 0 && i % 2 == 0)
                {
                    if(i == s)
                    {
                        break;
                    }
                    Console.Write(i+" ");
                }
            }
        }
    }