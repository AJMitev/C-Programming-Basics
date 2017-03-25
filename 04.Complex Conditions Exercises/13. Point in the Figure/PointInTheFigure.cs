using System;

class PointInTheFigure
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        bool isItInside = x > 0 && x < h * 3 && y > 0 && y < h || x > h && x < h * 2 && y > 0 && y < h * 4;
        bool isItBorder = y == 0 && x >= 0 && x <= h * 3 || y == h && x >= 0 && x <= h
            || y == h && x >= h * 2 && x <= h * 3 || y == 4 * h && x >= h && x <= h * 2 
            || x == h && y >= h && y <= h * 4 || x == h * 2 && y >= h && y <= h * 4 
            || x == 0 && y >= 0 && y <= h || x == h * 3 && y >= 0 && y <= h;   // First checking Top and bot and the ranges afther that checking sides

        if (isItInside)
        {
            Console.WriteLine("inside");
        }
        else if (isItBorder)
        {
            Console.WriteLine("border");
        }
        else
        {
            Console.WriteLine("outside");
        }
    }
}
