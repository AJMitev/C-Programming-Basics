using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nakovs_Game
{
    class nakovsGame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;

            for (int i = 0; i < n; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                sum1 = elements + sum1;
            }
            int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                int elements = int.Parse(Console.ReadLine());
                sum2 += elements;
            }
            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                int diff = Math.Abs(sum1 - sum2);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
