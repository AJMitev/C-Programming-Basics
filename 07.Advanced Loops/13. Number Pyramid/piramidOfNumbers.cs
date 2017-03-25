using System;

class piramidOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int row = 1;
        int cntr = 0;

        for (int i = 1; i <=n; i++)
        {
            for (int a = 1; a <= row; a++)
            {
                cntr++;
                if (i == 1 )
                {
                    Console.Write(cntr);
                }
                else
                {
                    Console.Write($"{cntr} ");
                }
                
                
                if (cntr == n)
                {
                    break;
                }
            }
            row++;
            Console.WriteLine();
            if (cntr==n)
            {
                break;
            }
        }

        }
    }


