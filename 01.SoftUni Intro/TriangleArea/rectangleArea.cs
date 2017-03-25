using System;

namespace RectangleArea
{
    class rectangleArea
    {
        static void Main()
        {
            var a = decimal.Parse(Console.ReadLine());
            var b = decimal.Parse(Console.ReadLine());
            var area = a * b;
            //Console.WriteLine(a*b);
            Console.WriteLine(area);
        }
    }
}
