using System;

namespace LessOrGreater
{
    class LessOrGreater
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            if (input < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (input > 99 && input < 201)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else Console.WriteLine("Greater than 200");
        }
    }
}
