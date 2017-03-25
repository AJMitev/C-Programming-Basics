using System;

namespace BonusPoints
{
    class BonusPoints
    {
        static void Main()
        {
            try
            {
                int points = int.Parse(Console.ReadLine());
                double bonus = 0;
                if (points <= 100)
                {
                    bonus = 5;                    
                }
                else if (points >= 101 && points <= 999)
                {
                    bonus = (points * 0.2);
                }
                else if (points >= 1000)
                {
                    bonus = (points * 0.10);
                } if (points % 2 == 0)
                {
                    bonus = bonus + 1;
                }
                else if (points % 5 == 0)
                {
                    bonus = bonus + 2;
                }
                Console.WriteLine(bonus);
                Console.WriteLine(points + bonus);

            }
            catch (Exception)
            {
                Console.WriteLine("Integer numbers only!");
            }
        }
    }
}
