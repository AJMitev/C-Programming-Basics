using System;

    class Probem6
    {
        static void Main()
        {
            //Input
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlingNumber = int.Parse(Console.ReadLine());

            //Logic

            int combos = 0;
            int result = 0;

            for (int i = 1; i <=n; i++)
            {
                for (int j = m; j >=1; j--)
                {
                    combos++;
                     result = result+ (i * 2) + (j * 3);
                    if (result>=controlingNumber)
                    {
                        break;
                    }
                }
                if (result >= controlingNumber)
                {
                    break;
                }
            }

            //Output
            if (result >=controlingNumber)
            {
                Console.WriteLine($"{combos} moves\nScore: {result} >= {controlingNumber}");
            }
            else
            {
                Console.WriteLine($"{combos} moves");
            }
           
        }
    }
