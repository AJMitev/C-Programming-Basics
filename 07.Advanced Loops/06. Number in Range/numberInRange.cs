using System;

class numberInRange
{
    static void Main(string[] args)
    {

        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            bool isItInRagne = n > 0 && n <= 100;

            if (isItInRagne == true)
            {
                Console.WriteLine($"Еnter a number in the range [1...100]: {n}\nThe Number Is {n}");
                break;
            }
            else
            {
                Console.WriteLine($"Еnter a number in the range [1...100]: {n}\nInvalid number!");
            }
        }
        

        
    }
}

