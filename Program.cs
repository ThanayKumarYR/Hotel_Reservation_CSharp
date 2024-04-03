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
            DaysCalculator daysCalculator = new DaysCalculator();

            hotels[0] = new Hotel("Lakewood",110,90,3,80,80);
            hotels[1] = new Hotel("Bridgewood", 150,50,4,110,50);
            hotels[2] = new Hotel("Ridgewood", 220,150,5,100,40);

            Console.WriteLine("\n1.Cheapest Hotels 2.BestRated Hotels 3.Exit");
            Console.Write("Enter the choice = ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Finding the Cheapest hotel !");
                    

                    var (CheapweekDays, CheapWeekEnds) = daysCalculator.Count();
                    if (CheapweekDays != -1 && CheapWeekEnds != -1)
                    {
                        Hotel.CheapestRegular(hotels, CheapweekDays, CheapWeekEnds);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Dates");
                    }
                    break;
                case 2:
                    Console.WriteLine("Finding the Best Hotels !");
                    var (BestweekDays, BestWeekEnds) = daysCalculator.Count();
                    if (BestweekDays != -1 && BestWeekEnds != -1)
                    {
                        Hotel.BestRegular(hotels, BestweekDays, BestWeekEnds);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Dates");
                    }
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
