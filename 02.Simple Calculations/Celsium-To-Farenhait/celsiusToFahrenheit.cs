using System;

namespace Celsius_To_Fahrenheit
{
    class celsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine(Math.Round(fahrenheit));
        }
    }
}
