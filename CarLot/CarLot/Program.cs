using System;
using System.Collections.Generic;

namespace CarLots
{
    class Program
    { 

        static void Main(string[] args)
        {
            CarLot Lot1 = new CarLot("Lot1");
            CarLot Lot2 = new CarLot("Lot2");
            Vehicle veh1 = new Car("ABC-1234", "Ford", "Mustang", "25,000", "coupe", 2);
            Vehicle veh2 = new Car("BKL-9866", "Toyota", "Camry", "19,000", "sedan", 4);
            Vehicle veh3 = new Truck("LKY-2901", "Chevrolet", "Silverado 1500", "35,000", 6);
            Vehicle veh4 = new Truck("BTG-0879", "Toyota", "Tundra", "42,500", 8);
            Vehicle veh5 = new Car("YZH-0045", "Honda", "Accord", "22,750", "sedan", 4);
            Vehicle veh6 = new Truck("TRG-3387", "Ford", "F150", "38,000", 6);
            Lot1.AddVehicle(veh1);
            Lot1.AddVehicle(veh2);
            Lot1.AddVehicle(veh3);
            Lot2.AddVehicle(veh4);
            Lot2.AddVehicle(veh5);
            Lot2.AddVehicle(veh6);
            Lot1.PrintInventory();
            Console.WriteLine(" ");
            Lot2.PrintInventory();
        }
    }
    class CarLot
    {
        //fields
        public string Name { get; private set; }
        public List<Vehicle> VehicleList = new List<Vehicle>();
        //constructor
        public CarLot(string InitialName)
        {
            Name = InitialName;
        }
        //method that adds vehicle to carlot
        public virtual void AddVehicle(Vehicle veh1)
        {
            VehicleList.Add(veh1);
        }
        //method that prints inventory of carlot, # of vehicles, vehicle details
        public virtual void PrintInventory()
        {
            Console.WriteLine("Car lot {0} vehicles: \n", Name);
            foreach (Vehicle vehicle in VehicleList)
            {
                Console.WriteLine(vehicle.Description());
            }
        }
    }
    abstract public class Vehicle
    {
        //fields
        public string LicenseNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Price { get; set; }
        //constructor
        public Vehicle(string licenseNumber, string make, string model, string price)
        {
            LicenseNumber = licenseNumber;
            Make = make;
            Model = model;
            Price = price;
        }
        //virtual method to print vehicle description
        public virtual string Description()
        {
            string Descrip = Make + " " + Model + " " + "| Lic #: " + LicenseNumber + "| Price: $" + Price;
            return Descrip;
        }
    }
    public class Truck : Vehicle
    {
        //fields
        public int Bedsize { get; private set; }
        //constructor
        public Truck(string licenseNumber, string make, string model, string price, int bedSize):base(licenseNumber, make, model, price)
        {
            LicenseNumber = licenseNumber;
            Make = make;
            Model = model;
            Price = price;
            Bedsize = bedSize;
        }
        //method to print vehicle description and overrides description since truck class
        public override string Description()
        {
            string Descrip = Make + " " + Model + "| Bed Size: " + Bedsize + "ft" + "| Lic #: " + LicenseNumber + "| Price: $"+ Price;
            return Descrip;
        }
    }
    public class Car : Vehicle
    {
        //fields
        public static string Type { get; private set; }
        public static int Doors { get; private set; }
        //constructor
        public Car(string licenseNumber, string make, string model, string price, string type, int doors):base(licenseNumber, make, model, price)
        {
            LicenseNumber = licenseNumber;
            Make = make;
            Model = model;
            Price = price;
            Type = type;
            Doors = doors;
        }
        //method to print vehicle description and overrides description since car class
        public override string Description()
        {
            string Descrip = Make + " " + Model +" |"+ Doors + "door " + Type + "| Lic #: " + LicenseNumber + "| Price: $" + Price;
            return Descrip;
        }
    }
}
