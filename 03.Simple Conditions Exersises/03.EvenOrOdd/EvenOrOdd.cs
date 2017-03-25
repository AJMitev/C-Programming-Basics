using System;

    class EvenOrOdd
    {
        static void Main(string[] args)
        {
        double number = double.Parse(Console.ReadLine());
        bool even = (number % 2 == 0);
        if (even == true)
        {
            Console.WriteLine("even");
        }
        else Console.WriteLine("odd");
        }
    }