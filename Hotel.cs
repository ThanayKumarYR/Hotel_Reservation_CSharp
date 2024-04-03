using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    class Hotel
    {
        public string HotelName { get; set; }
        public int WeekDayRegular { get; set; }    
        public int WeekEndRegular { get; set; }
        
        public Hotel(string name, int weekDayRate,int weekEndRate) 
        {
            HotelName = name;
            WeekDayRegular = weekDayRate;
            WeekEndRegular = weekEndRate;
            DisplayHotel();
        }

        public void DisplayHotel()
        {
            Console.WriteLine($"Hotel '{HotelName}' with regular customer rate for Week Day is ${WeekDayRegular} and Week End is ${WeekEndRegular}.");
        }

        public static void CheapestRegular(Hotel[] hotels,int days)
        { 
           int cheapestPrice = hotels.Min((hotel) => hotel.WeekDayRegular);
           Hotel cheapestHotel = hotels.Single((hotel) => hotel.WeekDayRegular == cheapestPrice);
           Console.WriteLine($"{cheapestHotel.HotelName}, Total Price = ${cheapestPrice*days}");
        }
    }
}
 