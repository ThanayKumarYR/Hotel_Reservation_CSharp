using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel Reservation !");

            Hotel[] hotels = new Hotel[3];

            hotels[0] = new Hotel("Lakewood",110,90);
            hotels[1] = new Hotel("Bridgewood", 150,50);
            hotels[2] = new Hotel("Ridgewood", 220,150);

            DaysCalculator daysCalculator = new DaysCalculator();

            var (weekDays,WeekEnds) = daysCalculator.Count();
            if (weekDays != -1)
            {
                Hotel.CheapestRegular(hotels,weekDays,WeekEnds);
            }
            else 
            {
                Console.WriteLine("Invalid Dates");
            }

        }
    }
}
