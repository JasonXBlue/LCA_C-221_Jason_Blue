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
            Console.WriteLine("Driver License: " + "\n");
            Console.WriteLine("License#: {0} | Gender: {1} | {2}",
                Example1.LicenseNumber, Example1.Gender, Example1.FullName);
            Console.WriteLine("License#: {0} | Gender: {1} | {2}",
                Example2.LicenseNumber, Example2.Gender, Example2.FullName);
            Console.WriteLine("License#: {0} | Gender: {1} | {2}",
                Example3.LicenseNumber, Example3.Gender, Example3.FullName);

            Book Book1 = new Book("The Great Gatsby", "F.Scott Fitzgerald", 180, 0743273567, "Scribner", 9.89);

            Console.WriteLine("\n" + "Books: " + "\n");
            Console.WriteLine("Title: {0} Author{1}",
                Book1.Title, Book1.Authors);
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
}