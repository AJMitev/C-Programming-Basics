using System;

namespace VegetablesShop
{
    class VegetableShop
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double frutsPrice = double.Parse(Console.ReadLine());
            int vegetableWeight = int.Parse(Console.ReadLine());
            int frutsWeight = int.Parse(Console.ReadLine());

            double vegetableValue = vegetablePrice * vegetableWeight;
            double frutsValue = frutsPrice * frutsWeight;
            double euroValue = (frutsValue + vegetableValue) / 1.94;
            Console.WriteLine(euroValue);
        }
    }
}
