using System;

class Border
{
    static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool isOnTop = x == x1 && y1 <= y && y <= y2;
        bool isOnBottom = x == x2 && y1 <= y && y <= y2;
        bool isOnLeft = y == y1 && x1 <= x && x <= x2;
        bool isOnRight = y == y2 && x1 <= x && x <= x2; ;

        if (isOnTop || isOnBottom || isOnLeft || isOnRight)
        {
            Console.WriteLine("Border");
        }
        else
        {
            Console.WriteLine("Inside / Outside");
        }
    }
}

