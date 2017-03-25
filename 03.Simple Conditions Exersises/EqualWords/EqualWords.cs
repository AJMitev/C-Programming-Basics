using System;

namespace EqualWords
{
    class EqualWords
    {
        static void Main()
        {
            string one = Console.ReadLine().ToLower();
            string two = Console.ReadLine().ToLower();
            if (one == two)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
