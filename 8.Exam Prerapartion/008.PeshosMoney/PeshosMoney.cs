using System;

namespace PeshosMoney
{
    class PeshosMoney
    {
        static void Main()
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double yans = double.Parse(Console.ReadLine());
            double marj = double.Parse(Console.ReadLine());
            if (marj >= 0 && marj <= 5)
            {
                int bitcoinsLevaValue = bitcoins * 1168;
                double yansLevaValue = (yans * 0.15) * 1.76;
                double euros = (bitcoinsLevaValue + yansLevaValue) / 1.95;
                double marjValue = euros * (marj / 100);
                double totalValue = euros - marjValue;
                Console.WriteLine(totalValue);
            }
            else Console.WriteLine("The Tax should be between 0-5%");
        }
    }
}
