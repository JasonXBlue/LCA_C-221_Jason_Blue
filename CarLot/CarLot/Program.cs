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

            
            
            
        }
    }
    class CarLot
    {
        public string Name { get; private set; }
        public List<Vehicle> VehicleList = new List<Vehicle>();
        

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
            Console.WriteLine("Car lot {0} vehicles: ", Name);
            foreach (Vehicle vehicle in VehicleList)
            {
                Console.WriteLine(vehicle.);
            }
        }
    }
    abstract public class Vehicle
    {
        public string LicenseNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Price { get; set; }

        public Vehicle(string licenseNumber, string make, string model, string price)
        {
            LicenseNumber = licenseNumber;
            Make = make;
            Model = model;
            Price = price;
        }
        public virtual string Description()
        {
            string Descrip = Make + " " + Model + "| Lic #: " + LicenseNumber + "| Price: $";
            return Descrip;
        }
    }
    public class Truck : Vehicle
    {
        public int Bedsize { get; private set; }

        public Truck(string licenseNumber, string make, string model, string price, int bedSize):base(licenseNumber, make, model, price)
        {
            LicenseNumber = licenseNumber;
            Make = make;
            Model = model;
            Price = price;
            Bedsize = bedSize;
        }
        public override string Description()
        {
            string Descrip = Make + " " + Model + "Bed Size: " + Bedsize + "ft" + "| Lic #: " + LicenseNumber + "| Price: $";
            return Descrip;
        }
    }
    public class Car : Vehicle
    {
        public static string Type { get; private set; }
        public static int Doors { get; private set; }

        public Car(string licenseNumber, string make, string model, string price, string type, int doors):base(licenseNumber, make, model, price)
        {
            LicenseNumber = licenseNumber;
            Make = make;
            Model = model;
            Price = price;
            Type = type;
            Doors = doors;
        }
        public override string Description()
        {
            string Descrip = Make + " " + Model + Doors + "door " + Type + "| Lic #: " + LicenseNumber + "| Price: $";
            return Descrip;
        }
    }
}
