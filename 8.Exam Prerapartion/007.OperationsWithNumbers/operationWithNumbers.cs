using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsWithNumbers
{
    class operationWithNumbers
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            if (operation == "+")
            {
                int result = number1 + number2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} + {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} + {number2} = {result} - odd");
                }
            }
            else if (operation == "-")
            {
                int result = number1 - number2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} - {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} - {number2} = {result} - odd");
                }
            }
            else if (operation == "*")
            {
                int result = number1 * number2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} * {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} * {number2} = {result} - odd");
                }
            }
            else if (operation == "/")
            {
                double result = (double)number1 / number2;
                if (number2 != 0.0)
                {
                    Console.WriteLine($"{number1} / {number2} = {Math.Round(result, 2)}");
                }
                else if (number2 == 0.0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }

            }
            else if (operation == "%")
            {
                double result = (double)number1 % number2;
                if (number2 != 0)
                {
                    Console.WriteLine($"{number1} % {number2} = {Math.Round(result,2)}");
                }
                else if (number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }
            }
        }
    }
}
