using System;
class Program
{
    static void Main(string[] args)
    {
        string townName = Console.ReadLine().ToLower();
        double productsSale = double.Parse(Console.ReadLine());
        double comission = 0;

        if (townName == "sofia")
        {
            if (productsSale >= 0 && productsSale <= 500)
            {
                comission = 0.05;
                Console.WriteLine(Math.Round(productsSale*comission,2));
            }
            else if (productsSale > 500 & productsSale <= 1000 )
            {
                comission = 0.07;
                Console.WriteLine(Math.Round(productsSale*comission,2));
            }
            else if (productsSale > 1000 && productsSale <= 10000)
            {
                comission = 0.08;
                Console.WriteLine(Math.Round(productsSale*comission,2));
            }
            else if (productsSale > 10000)
            {
                comission = 0.12;
                Console.WriteLine(Math.Round(productsSale*comission,2));
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (townName == "varna")
        {
            if (productsSale >= 0 && productsSale <= 500)
            {
                comission = 0.045;
                Console.WriteLine(Math.Round(productsSale * comission, 2));
            }
            else if (productsSale > 500 & productsSale <= 1000)
            {
                comission = 0.075;
                Console.WriteLine(Math.Round(productsSale * comission, 2));
            }
            else if (productsSale > 1000 && productsSale <= 10000)
            {
                comission = 0.10;
                Console.WriteLine(Math.Round(productsSale * comission, 2));
            }
            else if (productsSale > 10000)
            {
                comission = 0.13;
                Console.WriteLine(Math.Round(productsSale * comission, 2));
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (townName == "plovdiv")
        {
            if (productsSale >= 0 && productsSale <= 500)
            {
                comission = 0.055;
                Console.WriteLine(Math.Round(productsSale * comission, 2));
            }
            else if (productsSale > 500 & productsSale <= 1000)
            {
                comission = 0.08;
                Console.WriteLine(Math.Round(productsSale * comission, 2));
            }
            else if (productsSale > 1000 && productsSale <= 10000)
            {
                comission = 0.12;
                Console.WriteLine(Math.Round(productsSale * comission, 2));
            }
            else if (productsSale > 10000)
            {
                comission = 0.145;
                Console.WriteLine(Math.Round(productsSale * comission, 2));
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}

