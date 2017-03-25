using System;
using System.Collections.Generic;

namespace UnitConvertor
{
    class UnitConvertor
    {
        static void Main()
        {
            double value = double.Parse(Console.ReadLine());
            string unitOne = Console.ReadLine();
            string unitTwo = Console.ReadLine();
            var units = new Dictionary<string, double>
            {
                {"m", 1 },
                {"mm", 1000},
                {"cm", 100},
                {"mi", 0.000621371192},
                {"in", 39.3700787},
                {"km", 0.001 },
                {"ft", 3.2808399 },
                {"yd", 1.0936133 }
            };
            double result = value * (units[unitTwo] / units[unitOne]);
            Console.WriteLine($"{result} {unitTwo}");
        }
    }
}
