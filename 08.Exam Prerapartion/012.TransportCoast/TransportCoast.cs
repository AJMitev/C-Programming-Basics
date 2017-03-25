using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCoast
{
    class TransportCoast
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string sunState = Console.ReadLine().ToLower();
            if (n < 20)
            {
                if (sunState == "day")
                {
                    Console.WriteLine(0.7 + n * 0.79);
                }
                else Console.WriteLine(0.7 + n * 0.90);
            }
            else if (n < 100)
            {
                Console.WriteLine(n*0.09);
            }
            else if (n >= 100)
            {
                Console.WriteLine(n * 0.06);
            }

        }
    }
}
