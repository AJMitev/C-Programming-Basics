using System;

namespace VegetableShop
{
    class VegetableShop
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double frutsPrice = double.Parse(Console.ReadLine());
            int vegetableWeight = int.Parse(Console.ReadLine());
            int frutsWeight = int.Parse(Console.ReadLine());
            if (vegetablePrice >= 0 && vegetablePrice <= 1000)
            {
                if (frutsPrice >= 0 && frutsPrice <= 1000)
                {
                    if (vegetableWeight >= 0 && vegetableWeight <= 1000)
                    {
                        if (frutsWeight >= 0 && frutsWeight <= 1000)
                        {
                            double vegetableValue = vegetablePrice * vegetableWeight;
                            double frutsValue = frutsPrice * frutsWeight;
                            double euroValue = (frutsValue + vegetableValue) / 1.94;
                            Console.WriteLine(euroValue);
                        }
                        else Console.WriteLine("Incorect Input => Enter a number between 0.00 and 1000.00");
                    }
                    else Console.WriteLine("Incorect Input => Enter a number between 0.00 and 1000.00");
                }
                else Console.WriteLine("Incorect Input => Enter a number between 0.00 and 1000.00");
            }
            else Console.WriteLine("Incorect Input => Enter a number between 0.00 and 1000.00");
        } 

            
    }
}