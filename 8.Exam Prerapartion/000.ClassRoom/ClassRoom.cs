using System;

namespace ClassRoom
{
    class ClassRoom
    {
        static void Main()
        {
            double w = double.Parse(Console.ReadLine()) * 100;
            double h = double.Parse(Console.ReadLine()) * 100;

            if (h >= 3 && w <= 100)
            {
                double rows = Math.Truncate(w / 120);
                double colums = Math.Truncate((h - 100) / 70);
                Console.WriteLine(rows * colums - 3);

            }
            else Console.WriteLine("Please enter numbers in range of 3 >= w >= h >= 100!");
            
        }
    }
}
