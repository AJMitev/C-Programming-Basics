using System;

namespace ChristmassTree
{
    class ChristmassTree
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(new string(' ', n + 1) + "^");
            for (int i = 0; i < n; i++)
            {
                string stars = new string('*', i);
                string spaces = new string(' ', n - i);

                Console.WriteLine(spaces + stars + " | " + stars + spaces);
                //Console.Write(stars);
                //Console.Write(" | ");
                //Console.Write(stars);
                //Console.WriteLine(spaces);

            }
        }
    }
}
