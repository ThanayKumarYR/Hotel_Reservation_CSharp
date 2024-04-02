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

            hotels[0] = new Hotel("Lakewood",110);
            hotels[1] = new Hotel("Bridgewood", 160);
            hotels[2] = new Hotel("Ridgewood", 220);

            DaysCalculator daysCalculator = new DaysCalculator();

            int days = daysCalculator.Count();
            if (days != -1)
            {
                Hotel.CheapestRegular(hotels, days);
            }
            else 
            {
                Console.WriteLine("Invalid Dates");
            }

        }
    }
}
