using System;

class numberTable
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int cntr = 0;
        bool lamp = false;

        for (int i = 1; i <= n; i++)
        {
            cntr = i;
            Console.Write(cntr);
            if (cntr == n)
            {
                lamp = true;
            }
            else
            {
                lamp = false;
            }

            for (int k = 2; k <= n; k++)
            {
                if (!lamp)
                {
                    cntr++;
                }
                else cntr--;
                if (cntr == n)
                {
                    lamp = true;
                }

                Console.Write($" {cntr}");

            }
            Console.WriteLine();
        }

    }
}

