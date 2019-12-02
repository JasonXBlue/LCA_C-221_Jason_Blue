using System;
using System.Collections.Generic;

namespace CarLots
{
    class Program
    {
        private static CarLot CarLot1;
        private static CarLot CarLot2;
        private static object Vehicle1;

        static void Main(string[] args)
        {
            CarLot1 = new CarLot("Uno Lot");
            CarLot2 = new CarLot("Dos Lot");
            
            
        }
    }
    class CarLot
    {
        public string Name { get; private set; }
        private List<Vehicle> VehicleList = new List<Vehicle>();
        

        public CarLot(string InitialName)
        {
            Name = InitialName;
            //this.VehicleList = new
        }
        //method that adds vehicle to carlot
        public void AddVehicle(Vehicle LicenseNumber, Vehicle Make, Vehicle Model, Vehicle Price)
        {
            //VehicleList.Add;
            

            
        }
        //method that prints inventory of carlot, # of vehicles, vehicle details
        public void PrintInventory()
        {

        }
    }
    abstract public class Vehicle
    {
        public string LicenseNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Price { get; set; }
        public Vehicle(string LicenseNumber, string Make, string Model, string Price)
        {
            this.LicenseNumber = LicenseNumber;
            this.Make = Make;
            this.Model = Model;
            this.Price = Price;
        }
        public (string LicenseNumber, string Make, string Model, string Price) VehicleInfo()
        {
            return (LicenseNumber, Make, Model, Price);
        }
    }
    abstract public class Truck : Vehicle
    {
        public static string LicenseNumberInit { get; private set; }
        public static string MakeInit { get; private set; }
        public static string ModelInit { get; private set; }
        public static string PriceInit { get; private set; }
        public string Bedside { get; private set; }

        public Truck (string BedSizeInit):base (LicenseNumberInit, MakeInit, ModelInit, PriceInit)
        {
            Bedside = BedSizeInit;
        }
    }
    abstract public class Car : Vehicle
    {
        public static string LicenseNumberInit { get; private set; }
        public static string MakeInit { get; private set; }
        public static string ModelInit { get; private set; }
        public static string PriceInit { get; private set; }
        public static string Type { get; private set; }
        public static int Doors { get; private set; }
        public Car (string TypeInit, int DoorsInit):base(LicenseNumberInit, MakeInit, ModelInit, PriceInit)
        {
            Type = TypeInit;
            Doors = DoorsInit;
        }
    }
}
