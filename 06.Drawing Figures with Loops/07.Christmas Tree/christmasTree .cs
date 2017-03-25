using System;

namespace ChristmassTree
{
    class ChristmassTree
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n+1; i++)
            {
                string stars = new string('*', i);
                string spaces = new string(' ', n - i);

                Console.WriteLine(spaces + stars + " | " + stars + spaces);

            }
        }
    }
}
