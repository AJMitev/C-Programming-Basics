using System;

namespace GuessThePass
{
    class GuessPassword
    {
        static void Main()
        {
            string input = Console.ReadLine();

            if (input == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }

        }
    }
}

