using System;

namespace PlatesPerMinute
{
    class PlatesPerMinute
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int o = int.Parse(Console.ReadLine());
            int area = n * n;
            double plates = w * l;
            int bench = m * o;
            double howManyPlates = (area - bench) / plates;
            double platesPerMinute = howManyPlates * 0.2;

            Console.WriteLine(howManyPlates);
            Console.WriteLine(platesPerMinute);
        }
    }
}