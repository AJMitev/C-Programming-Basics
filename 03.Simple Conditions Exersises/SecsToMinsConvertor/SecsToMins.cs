using System;

namespace SecsToMinsConvertor
{
    class SecsToMins
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            double result = num1 + num2 + num3;
            string format = string.Format("{0}:{1:00}", (int)result / 60, result % 60);
            Console.WriteLine(format);
        }
    }
}
