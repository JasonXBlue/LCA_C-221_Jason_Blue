using System;

namespace PoCos
{
    class Program
    {
        static void Main(string[] args)
        {
            DriverLicense Example1 = new DriverLicense("Jason", "Blue", "M", 123456);
            DriverLicense Example2 = new DriverLicense("Jane", "Doe", "F", 567890);
            DriverLicense Example3 = new DriverLicense("Joe", "Smith", "M", 987654);
            //Print DriverLicense class examples
            Console.WriteLine("Driver License: " + "\n");
            Console.WriteLine("License#: {0} | Gender: {1} | {2}",
                Example1.LicenseNumber, Example1.Gender, Example1.FullName);
            Console.WriteLine("License#: {0} | Gender: {1} | {2}",
                Example2.LicenseNumber, Example2.Gender, Example2.FullName);
            Console.WriteLine("License#: {0} | Gender: {1} | {2}",
                Example3.LicenseNumber, Example3.Gender, Example3.FullName);
            Book Book1 = new Book("The Great Gatsby", "F.Scott Fitzgerald", 180, 0743273567, "Scribner", 9.89);
            Book Book2 = new Book("Moby Dick", "Herman Melville", 378, 1503280780, "CreateSpace", 12.11);
            Book Book3 = new Book("Of Mice and Men", "John Steinbeck", 107, 0140177396, "Penguin Books", 9.22);
            //Print Book class examples
            Console.WriteLine("\n" + "Books: " + "\n");
            Console.WriteLine("Title: {0} | Author: {1} | Pages: {2} \nSku: {3}          | Publisher: {4}        | Price: ${5}",
                Book1.Title, Book1.Authors, Book1.Pages, Book1.Sku, Book1.Publisher, Book1.Price);
            Console.WriteLine("\n"+"Title: {0}        | Author: {1}    | Pages: {2} \nSku: {3}         | Publisher: {4}     | Price: ${5}",
                Book2.Title, Book2.Authors, Book2.Pages, Book2.Sku, Book2.Publisher, Book2.Price);
            Console.WriteLine("\nTitle: {0}  | Author: {1}     | Pages: {2} \nSku: {3}          | Publisher: {4}   | Price: ${5}",
                Book3.Title, Book3.Authors, Book3.Pages, Book3.Sku, Book3.Publisher, Book3.Price);
            Airplane Plane1 = new Airplane("Boeing", "747", "400", 416, 4);
            Airplane Plane2 = new Airplane("Airbus", "A340", "300", 290, 4);
            Airplane Plane3 = new Airplane("Embraer", "190", "E-Jet", 98, 2);
            //Print Airplane class examples
            Console.WriteLine("\n" + "Airplanes: " + "\n");
            Console.WriteLine("Manufacturer: {0} \nModel: {1} \nVariant: {2} \nCapacity: {3} \nEngines: {4}",
                Plane1.Manufacturer, Plane1.Model, Plane1.Variant, Plane1.Capacity, Plane1.Engines);
            Console.WriteLine("\nManufacturer: {0} \nModel: {1} \nVariant: {2} \nCapacity: {3} \nEngines: {4}",
                Plane2.Manufacturer, Plane2.Model, Plane2.Variant, Plane2.Capacity, Plane2.Engines);
            Console.WriteLine("\nManufacturer: {0} \nModel: {1} \nVariant: {2} \nCapacity: {3} \nEngines: {4}",
                Plane3.Manufacturer, Plane3.Model, Plane3.Variant, Plane3.Capacity, Plane3.Engines);

        }
    }
    class DriverLicense
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int LicenseNumber { get; set; }
        //Constructor
        public DriverLicense(string InitialFirstName, string InitialLastName, string InitialGender, int InitialLicenseNum)
        {
            this.FirstName = InitialFirstName;
            this.LastName = InitialLastName;
            this.Gender = InitialGender;
            this.LicenseNumber = InitialLicenseNum;
        }
        //Get full name
        public String FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Authors { get; set; }
        public int Pages { get; set; }
        public int Sku { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }
        //Constructor
        public Book(string InitTitle, string InitAuthors, int InitPages, int InitSku, string InitPublisher, double InitPrice)
        {
            this.Title = InitTitle;
            this.Authors = InitAuthors;
            this.Pages = InitPages;
            this.Sku = InitSku;
            this.Publisher = InitPublisher;
            this.Price = InitPrice;
        }
    }
    class Airplane
    {
        private string v;

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Variant { get; set; }
        public int Capacity { get; set; }
        public int Engines { get; set; }
        //Constructor
        public Airplane(string InitManufacturer, string InitModel, string InitVariant, int InitCapacity, int InitEngines)
        {
            this.Manufacturer = InitManufacturer;
            this.Model = InitModel;
            this.Variant = InitVariant;
            this.Capacity = InitCapacity;
            this.Engines = InitEngines;
        }

        public Airplane(string v)
        {
            this.v = v;
        }
    }
}