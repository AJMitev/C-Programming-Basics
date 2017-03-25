using System;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal usd = decimal.Parse(Console.ReadLine());
            decimal bgn = 1.79549m;
            Console.WriteLine(Math.Round(usd*bgn,2) + " BGN");
        }
    }
}
