using System;

namespace Cirle_AreaAndPerimeter
{
    class circle
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("Area = {0} \nPerimeter = {1}", area, perimeter);            
        }
    }
}
