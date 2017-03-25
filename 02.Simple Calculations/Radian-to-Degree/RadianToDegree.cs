using System;

namespace Radian_to_Degree
{
    class RadianToDegree
    {
        static void Main()
        {
            double oneRadian = 57.29578;
            double newRadian = double.Parse(Console.ReadLine());
            double result = newRadian * oneRadian;
            Console.WriteLine(Math.Round(result));
        }
    }
}
