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
        public int TotalPrice { get; set; }
        public int Rating { get; set; }
        public Hotel(string name, int weekDayRate,int weekEndRate,int rating) 
        {
            HotelName = name;
            WeekDayRegular = weekDayRate;
            WeekEndRegular = weekEndRate;
            Rating = rating;
            DisplayHotel();
        }

        public void DisplayHotel()
        {
            Console.WriteLine($"Hotel '{HotelName}' with regular customer rate for Week Day is ${WeekDayRegular}, Week End is ${WeekEndRegular} and Rating {Rating}.");
        }

        public static void CheapestRegular(Hotel[] hotels,int days)
        { 
           int cheapestPrice = hotels.Min((hotel) => hotel.WeekDayRegular);
           Hotel cheapestHotel = hotels.Single((hotel) => hotel.WeekDayRegular == cheapestPrice);
           Console.WriteLine($"{cheapestHotel.HotelName}, Total Price = ${cheapestPrice*days}");
        }

        public static void CheapestRegular(Hotel[] hotels, int weekDays, int weekEnds)
        {
            int TotalPrice = int.MaxValue;
            Hotel cheapestHotel = hotels[0];
            foreach (Hotel hotel in hotels)
            {
                int WeekDayPrice = weekDays * hotel.WeekDayRegular;
                int WeekEndPrice = weekEnds * hotel.WeekEndRegular;
                hotel.TotalPrice = WeekDayPrice + WeekEndPrice;
                if (TotalPrice > hotel.TotalPrice) TotalPrice = hotel.TotalPrice;
                
            }

            IEnumerable<Hotel> hotelSelected = from hotel in hotels
                                         where hotel.TotalPrice <= TotalPrice
                                         select hotel;

            int BestRating = hotelSelected.Max((hotel) => hotel.Rating);

            hotelSelected = from hotel in hotels
                            where hotel.Rating == BestRating
                            select hotel;


            Console.WriteLine($"Cheapest Hotels are,");
            foreach (var hotel in hotelSelected)
            {
                Console.WriteLine($"{hotel.HotelName},Rating {hotel.Rating} Total Price = ${hotel.TotalPrice}");
            }
           
        }

    }
}
 