using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    class DaysCalculator
    {
        public int Count()
        {
            string format = "ddMMMyyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;
            Console.WriteLine("Reservation Dates");
            Console.Write("Enter the strating date in ddMmmyyyy format = ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), format, provider);
            Console.Write("Enter the ending date in ddMmmyyyy format = ");
            DateTime end = DateTime.ParseExact(Console.ReadLine(), format, provider);
            if (start <= end)
            {
                TimeSpan days = end - start;
                return days.Days + 1;
            }
            else { return -1; }
        }
    }
}
