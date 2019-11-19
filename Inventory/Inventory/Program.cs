using System;
using System.Collections.Generic;
using System.Globalization; // for use of .ToString("C", CultureInfo.CurrentCulture) to display as US currency

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> Rentals = new List<IRentable>();
            Rentals.Add(new Boat("Ski boat"));
            Rentals.Add(new Car("4 DR Hatchback"));
            Rentals.Add(new House("1234 Main St."));
            Rentals.Add(new Boat("Fish boat"));
            Rentals.Add(new Car("4 DR Sedan"));
            Rentals.Add(new House("4321 5th Ave."));
            Rentals.Add(new Boat("Speed boat"));
            Rentals.Add(new Car("2 DR Coupe"));
            Rentals.Add(new House("900 E. Broadway St."));
            
            foreach (IRentable rental in Rentals)
            {
                rental.GetDescription(); rental.GetDailyRate();
                
            }
        }
    }
    public interface IRentable
    {
        void GetDailyRate(); //method to convert rate to daily rate and display rate
        void GetDescription(); //method to get and display rental description
    }
    public class Boat : IRentable
    {
        String Descript;
        public Boat(string InitDescript)
        {
            this.Descript = InitDescript;
        }
        public void GetDailyRate()
        {
            float BoatHourlyRate = (float)15.10;
            float BoatDailyRate = (float)(BoatHourlyRate * 24.00); //convert hourly rate given to daily rate
            Console.WriteLine("Daily Rental Rate : " + BoatDailyRate.ToString("C", CultureInfo.CurrentCulture) + "\n"); //System.Globalization; that displays as US currency
        }
        public void GetDescription()
        {
            Console.WriteLine("Type : Boat | Descriptipn: {0}", Descript);
        }
    }
    public class House : IRentable
    {
        string Descript;
        public House(string InitDescript)
        {
            this.Descript = InitDescript;
        }
        public void GetDailyRate()
        {
            float HouseWeeklyRate = (float)750.99;
            float HouseDailyRate = (float)(HouseWeeklyRate / 7); //convert weekly rate given to daily rate
            Console.WriteLine("Daily Rental Rate : " + HouseDailyRate.ToString("C", CultureInfo.CurrentCulture) + "\n"); //System.Globalization; that displays as US currency
        }
        public void GetDescription()
        {
            Console.WriteLine("Type : House | Description {0}", Descript);
        }
    }
    public class Car : IRentable
    {
        string Descript;
        public Car(string InitDescript)
        {
            this.Descript = InitDescript;
        }
        public void GetDailyRate()
        {
            float CarDailyRate = (float)25.00;
            Console.WriteLine("Daily Rental Rate : " + CarDailyRate.ToString("C", CultureInfo.CurrentCulture) + "\n"); //System.Globalization; that displays as US currency
        }
        public void GetDescription()
        {
            Console.WriteLine("Type : Car | Description {0}", Descript);
        }
    }
}
