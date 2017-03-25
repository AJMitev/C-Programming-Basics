using System;

class Program
{
    static void Main(string[] args)
    {
        string productName = Console.ReadLine();
        string cityName = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());
        if (cityName == "Sofia")
        {
            if (productName == "coffee")
            {
                Console.WriteLine(0.50 * quantity);
            }
            else if (productName == "water")
            {
                Console.WriteLine(0.80 * quantity);
            }
            else if (productName == "beer")
            {
                Console.WriteLine(1.20 * quantity);
            }
            else if (productName == "sweets")
            {
                Console.WriteLine(1.45 * quantity);
            }
            else if (productName == "peanuts")
            {
                Console.WriteLine(1.60 * quantity);
            }
            else Console.WriteLine("No such product");
        }
        else if (cityName == "Plovdiv")
        {
            if (productName == "coffee")
            {
                Console.WriteLine(0.40 * quantity);
            }
            else if (productName == "water")
            {
                Console.WriteLine(0.70 * quantity);
            }
            else if (productName == "beer")
            {
                Console.WriteLine(1.15 * quantity);
            }
            else if (productName == "sweets")
            {
                Console.WriteLine(1.30 * quantity);
            }
            else if (productName == "peanuts")
            {
                Console.WriteLine(1.50 * quantity);
            }
            else Console.WriteLine("No such product");
        }
        else if (cityName == "Varna")
        {
            if (productName == "coffee")
            {
                Console.WriteLine(0.45 * quantity);
            }
            else if (productName == "water")
            {
                Console.WriteLine(0.70 * quantity);
            }
            else if (productName == "beer")
            {
                Console.WriteLine(1.10 * quantity);
            }
            else if (productName == "sweets")
            {
                Console.WriteLine(1.35 * quantity);
            }
            else if (productName == "peanuts")
            {
                Console.WriteLine(1.55 * quantity);
            }
            else Console.WriteLine("No such product");
        }
    }
}

