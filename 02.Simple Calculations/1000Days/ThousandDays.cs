using System;

namespace ThousandDaysToTheEarth
{
    class ThousandDays
    {
        static void Main()
        {
            string myBirthday = Console.ReadLine();
            string dateFormat = "dd-MM-yyyy";
            DateTime myNewValue = DateTime.ParseExact(myBirthday, dateFormat, null);
            myNewValue = myNewValue.AddDays(999);
            Console.WriteLine(myNewValue.ToString(dateFormat));
        }
    }
}
