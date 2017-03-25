using System;

class Volleyball
{
    static void Main(string[] args)
    {
        string typeOfYear = Console.ReadLine().ToLower();
        int holidays = int.Parse(Console.ReadLine());
        int weekendsInHometown = int.Parse(Console.ReadLine());
        int weekendsForVolleyball = 48;

        double weekednsInSofia = (weekendsForVolleyball - weekendsInHometown) * 0.750;
        double volleyballInHolidays = holidays * 0.66666666666666666666666666666666666666666;
        double totalVolleyball = weekednsInSofia + weekendsInHometown + volleyballInHolidays;
        if (typeOfYear.Equals("leap"))
        {
            double leapYear = totalVolleyball * 1.150;
            totalVolleyball += leapYear;
            Console.WriteLine(Math.Truncate(totalVolleyball));
        }
        else if (typeOfYear.Equals("normal"))
        {
            Console.WriteLine(Math.Truncate(totalVolleyball));
        }
        else
        {
            Console.WriteLine("unknown type of year on line 1");
        }


    }
}

