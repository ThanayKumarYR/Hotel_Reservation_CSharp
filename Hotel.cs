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
        public int WeekDayRewards {get;set;}
        public int WeekEndRewards {get;set;}
        public Hotel(string name, int weekDayRegular,int weekEndRegular,int rating,int weekDayRewards,int weekEndRewards) 
        {
            HotelName = name;
            WeekDayRegular = weekDayRegular;
            WeekEndRegular = weekEndRegular;
            Rating = rating;
            WeekDayRewards = weekDayRewards;
            WeekEndRewards = weekEndRewards;
            DisplayHotel();
        }
        public void DisplayHotel()
        {
            Console.WriteLine($"Hotel '{HotelName}' with regular customer rate for Week Day is ${WeekDayRegular}, Week End is ${WeekEndRegular} and Rating {Rating}.\nThe customer rewards for Week Day is ${WeekDayRewards}, Week End is ${WeekEndRewards}.\n");
        }
        public static void BestRegular(Hotel[] hotels,int weekDays,int weekEnds)
        { 
           int BestRating = hotels.Max((hotel) => hotel.Rating);
           //Hotel BestHotel = hotels.Single((hotel) => hotel.Rating == BestRating);
           IEnumerable<Hotel> BestHotelEnumerable = from hotel in hotels
                             where hotel.Rating == BestRating
                             select hotel;
            Hotel BestHotel = BestHotelEnumerable.FirstOrDefault();
            BestHotel.TotalPrice = (weekDays * BestHotel.WeekDayRegular) + (weekEnds * BestHotel.WeekEndRegular);
           Console.WriteLine($"{BestHotel.HotelName}, Total Price = ${BestHotel.TotalPrice}");
        }

        public static void BestRewards(Hotel[] hotels, int weekDays, int weekEnds)
        {
            int BestRating = hotels.Max((hotel) => hotel.Rating);
            Hotel BestHotel = hotels.Single((hotel) => hotel.Rating == BestRating);
            BestHotel.TotalPrice = (weekDays * BestHotel.WeekDayRewards) + (weekEnds * BestHotel.WeekEndRewards);
            Console.WriteLine($"{BestHotel.HotelName}, Total Price = ${BestHotel.TotalPrice}");
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


            Console.WriteLine($"Cheapest Hotels for Regular customer are,");
            foreach (var hotel in hotelSelected)
            {
                Console.WriteLine($"{hotel.HotelName},Rating {hotel.Rating} Total Price = ${hotel.TotalPrice}");
            }
           
        }
        public static void CheapestRewards(Hotel[] hotels, int weekDays, int weekEnds)
        {
            int TotalPrice = int.MaxValue;
            Hotel cheapestHotel = hotels[0];
            foreach (Hotel hotel in hotels)
            {
                int WeekDayPrice = weekDays * hotel.WeekDayRewards;
                int WeekEndPrice = weekEnds * hotel.WeekEndRewards;
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

            Console.WriteLine($"Cheapest Hotels for Reward Customer are,");
            foreach (var hotel in hotelSelected)
            {
                Console.WriteLine($"{hotel.HotelName},Rating {hotel.Rating} Total Price = ${hotel.TotalPrice}");
            }
        }

    }
}
 