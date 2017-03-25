using System;

class enterEvenNumber
{
    static void Main(string[] args)
    {
        int n = 0;
       
        while (true)
        {
            try
            {
                Console.Write("Enter even number: ");
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine($"Even number entered: {n}");
                    break;
                }
                else
                {
                    Console.WriteLine("Not Even");
                }


            }
            catch (Exception)
            {

                Console.WriteLine("This is not a number!");
            }
            
        }
    }
}

