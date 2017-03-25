using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumToText
{
    class NumToText
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (0 > number || number > 100)
            {
                Console.WriteLine("Invalid Number");
            }
            else if (number == 0)
            {
                Console.WriteLine("zero");
            }
            else if (number == 100)
            {
                Console.WriteLine("one hundred");
            }
            else
            {
                int tens = (number / 10) % 10;
                int ones = number % 10;
                if (tens == 1)
                {
                    switch (ones)
                    {
                        case 0:
                            Console.WriteLine("ten");
                            break;
                        case 1:
                            Console.WriteLine("eleven");
                            break;
                        case 2:
                            Console.WriteLine("twelve");
                            break;
                        case 3:
                            Console.WriteLine("thirteen");
                            break;
                        case 4:
                            Console.WriteLine("fourteen");
                            break;
                        case 5:
                            Console.WriteLine("fifteen");
                            break;
                        case 6:
                            Console.WriteLine("sixteen");
                            break;
                        case 7:
                            Console.WriteLine("seventeen");
                            break;
                        case 8:
                            Console.WriteLine("eighteen");
                            break;
                        case 9:
                            Console.WriteLine("nineteen");
                            break;
                        default:
                            Console.WriteLine();
                            break;
                    }
                }
                if (tens > 1)
                {
                    switch (tens)
                    {
                        case 2:
                            Console.Write("twenty");
                            break;
                        case 3:
                            Console.Write("thirty");
                            break;
                        case 4:
                            Console.Write("fourty");
                            break;
                        case 5:
                            Console.Write("fifty");
                            break;
                        case 6:
                            Console.Write("sixty");
                            break;
                        case 7:
                            Console.Write("seventy");
                            break;
                        case 8:
                            Console.Write("eighty");
                            break;
                        case 9:
                            Console.Write("ninety");
                            break;
                    }1``
                    if (ones != 0)
                    {
                        Console.Write(" ");
                    }
                }
                if (tens != 1)
                {
                    switch (ones)
                    {
                        case 1:
                            Console.WriteLine("one");
                            break;
                        case 2:
                            Console.WriteLine("two");
                            break;
                        case 3:
                            Console.WriteLine("three");
                            break;
                        case 4:
                            Console.WriteLine("four");
                            break;
                        case 5:
                            Console.WriteLine("five");
                            break;
                        case 6:
                            Console.WriteLine("six");
                            break;
                        case 7:
                            Console.WriteLine("seven");
                            break;
                        case 8:
                            Console.WriteLine("eight");
                            break;
                        case 9:
                            Console.WriteLine("nine");
                            break;
                        default:
                            Console.WriteLine();
                            break;
                    }
                }
            }
        }

    }
}

