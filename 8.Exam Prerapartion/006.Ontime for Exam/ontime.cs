using System;

class ontime
{
    static void Main(string[] args)
    {
        int examHours = int.Parse(Console.ReadLine());
        int examMinutes = int.Parse(Console.ReadLine());
        int ariveHours = int.Parse(Console.ReadLine());
        int ariveMinutes = int.Parse(Console.ReadLine());

        int toMinutes = ((examHours * 60) + examMinutes) - ((ariveHours * 60) + ariveMinutes);

        bool onTime = toMinutes == 0;
        bool inRange = toMinutes > 0 && toMinutes <= 30;
        bool late = toMinutes < 0;
        bool early = toMinutes > 30;

        if (onTime)
        {
            Console.WriteLine("On time");
        }
        else if (inRange)
        {
            if (toMinutes > 59)
            {
                int hours = toMinutes / 60;
                int minutes = toMinutes % 60;
                Console.WriteLine($"On time\n{hours}:{minutes:00} hours before the start");
            }
            Console.WriteLine($"On time\n{toMinutes} minutes before the start");
        }
        else if (late)
        {
            toMinutes = Math.Abs(toMinutes);
            if (toMinutes > 59)
            {
                int hours = toMinutes / 60;
                int minutes = toMinutes % 60;
                Console.WriteLine($"Late\n{hours}:{minutes:00} hours after the start");
            }
            else
            {
                Console.WriteLine($"Late\n{toMinutes} minutes after the start");
            }
        }
        else if (early)
        {
            if (toMinutes > 59)
            {
                int hours = toMinutes / 60;
                int minutes = toMinutes % 60;
                Console.WriteLine($"Early\n{hours}:{minutes:00} hours before the start");
            }
            else
            {
                Console.WriteLine($"Early\n{toMinutes} minutes before the start");
            }
        }
    }
}