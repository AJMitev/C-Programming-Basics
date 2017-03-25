using System;
using System.Collections.Generic;

namespace MoneyConvertor
{
    class MoneyConvertor
    {
        static void Main()
        {
            decimal moneyValue = decimal.Parse(Console.ReadLine());
            string firstCurrency = Console.ReadLine().ToUpper();
            string secondCurrency = Console.ReadLine().ToUpper();
            var currencies = new Dictionary<string, decimal>
            {
                { "BGN", 1.00m },
                { "EUR", 1.95583m},
                { "USD", 1.79549m},
                { "GBP", 2.53405m}
            };
            decimal calculation = moneyValue * (currencies[firstCurrency] / currencies[secondCurrency]);
            Console.WriteLine(Math.Round(calculation,2) + " {0}", secondCurrency);
        }
    }
}
