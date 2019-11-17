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
            CarLot1.AddVehicle();
            
        }
    }
    class CarLot
    {
        public string Name { get; set; }
        public List<Vehicle> VehicleList = new List<Vehicle>();
        public CarLot(string NameInit)
        {
            Name = NameInit;
        }
        //method that adds vehicle to carlot
        public void AddVehicle()
        {
            //VehicleList.Add;
            
        }
        //method that prints inventory of carlot, # of vehicles, vehicle details
        public void PrintInventory()
        {

        }
    }
    public abstract class Vehicle
    {
        public string LicenseNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Price { get; set; }
        public Vehicle(string LicenseNumberInit, string MakeInit, string ModelInit, string PriceInit)
        {
            LicenseNumber = LicenseNumberInit;
            Make = MakeInit;
            Model = ModelInit;
            Price = PriceInit;
        }
        public void VehicleInfo()
        {
            Console.WriteLine(LicenseNumber, Make, Model, Price);
        }
    }
    public class Truck : Vehicle
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
    public class Car : Vehicle
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
