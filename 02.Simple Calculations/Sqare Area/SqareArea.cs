using System;

namespace Sqare_Area
{
    class SqareArea
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Sqare = ");
            Console.WriteLine(Math.Pow(a, 2)); 
        }
    }
}
