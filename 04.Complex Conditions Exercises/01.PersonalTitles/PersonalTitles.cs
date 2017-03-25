using System;

namespace PersonalTitles
{
    class PersonalTitles
    {
        static void Main()
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine().ToLower();
            if (age < 16)
            {
                if (gender.Equals("m"))
                {
                    Console.WriteLine("Master");
                } else
                if (gender.Equals("f"))
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("No such gender!");
                }
            }
            else if (age >= 16)
            {
                if (gender.Equals("m"))
                {
                    Console.WriteLine("Mr.");
                } else
                if (gender.Equals("f"))
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("No such gender!");
                }
            }
        }
    }
}
