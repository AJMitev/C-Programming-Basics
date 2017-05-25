using System;

class IsThereEnoughMoney
{
    static void Main()
    {
       decimal money = decimal.Parse(Console.ReadLine());
       decimal rate = decimal.Parse(Console.ReadLine());
       decimal pizzaPrice = decimal.Parse(Console.ReadLine());
       decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
       decimal sandwitchPrice = decimal.Parse(Console.ReadLine());
       uint pizzaQuantity = uint.Parse(Console.ReadLine());
       uint lasagnaQuantity = uint.Parse(Console.ReadLine());
       uint sandwitchQuantity = uint.Parse(Console.ReadLine());

        //Logic
        decimal moneyForPizza = (pizzaPrice * pizzaQuantity) / rate;
        decimal moneyForLasagna = (lasagnaPrice * lasagnaQuantity) / rate;
        decimal moneyForSandwich = (sandwitchPrice * sandwitchQuantity) / rate;
        bool isEnoughMoney = (moneyForLasagna + moneyForPizza + moneyForSandwich) <= money;
        decimal difference = Math.Abs((moneyForLasagna + moneyForPizza + moneyForSandwich) - money);
        //Output
        if (isEnoughMoney)
        {
            Console.WriteLine($"Garfield is well fed, John is awesome. Money left: ${difference:0.00}.");
        }
        else
        {
            Console.WriteLine($"Garfield is hungry. John is a badass. Money needed: ${difference:0.00}.");
        }
    }
}

