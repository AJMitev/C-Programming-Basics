using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class hotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double apartament = 0.0;
            double studio = 0.0;
            double discount = 0.0;
            switch (month)
            {
                case "May":
                case "October":
                    apartament = days * 65;
                    studio = days * 50;
                    break;
                case "June":
                case "September":
                    studio = days * 75.20;
                    apartament = days * 68.70;
                    break;
                case "July":
                case "August":
                    studio = days * 76;
                    apartament = days * 77;
                    break;
                default:
                    Console.WriteLine("Enter Valid Month");
                    break;
            }
            if (days > 7 && days <14 && month =="May" || days > 7 && days < 14 && month == "October")
            {
                discount = studio * 0.05;
                studio -= discount;
            }
            else if (days > 14 && month == "May" || days > 14 && month == "October")
            {
                discount = studio * 0.30;
                studio -= discount;
            }
            else if (days > 14 && month == "June" || days > 14 && month == "September")
            {
                discount = studio * 0.20;
                studio -= discount;
            }
            if (days > 14)
            {
                discount = apartament * 0.10;
                apartament -= discount;
            }
            Console.WriteLine($"Apartment: {Math.Round(apartament,2):0.00} lv.\nStudio: {Math.Round(studio,2):0.00} lv.");
        }
    }
}
