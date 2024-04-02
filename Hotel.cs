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
        public int RegularCustomerRate { get; set; }    
        public Hotel(string name, int rate) 
        {
            HotelName = name;
            RegularCustomerRate = rate;
            DisplayHotel();
        }

        public void DisplayHotel()
        {
            Console.WriteLine($"Hotel '{HotelName}' with regular customer rate ${RegularCustomerRate}.");
        }

        public static void CheapestRegular(Hotel[] hotels,int days)
        { 
           int cheapestPrice = hotels.Min((hotel) => hotel.RegularCustomerRate);
           Hotel cheapestHotel = hotels.Single((hotel) => hotel.RegularCustomerRate == cheapestPrice);
           Console.WriteLine($"{cheapestHotel.HotelName}, Total Price = ${cheapestPrice*days}");
        }
    }
}
