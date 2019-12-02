using System;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace BooksInventory
{
    class Book
    {
        public int Id { get; private set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public Book(String Title, String Author)
        {
            this.Title = Title;
            this.Author = Author;
        }
    }
    class BooksContext : DbContext
    {

        // This property corresponds to the table in our database
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=/Users/jasonblue/Desktop/books.db");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate an instance of the context
            BooksContext context = new BooksContext();

            // makes sure that the table exists, 
            //and creates it if it does not already exist
            context.Database.EnsureCreated();

            bool Quit = false;
            while (!Quit)
            {


                // ask the user for a student to add
                Console.WriteLine("Enter book title and author or Q to Quit:");
                String fullBook = Console.ReadLine();
                String[] parts = fullBook.Split();
                if (fullBook == "Q")
                {
                    Quit = true;
                }

                // split the input into parts, and make sure 
                // we have 2 parts only
                //String[] parts = fullBook.Split();

                else if (parts.Length == 2)

                {
                    // create a new student object, notice that we do not 
                    // select an id, we let the framework handle that
                    Book newBook = new Book(parts[0], parts[1]);

                    // add the newly created student instance to the context
                    // notice how similar this is to adding a item to a list,
                    context.Books.Add(newBook);

                    // ask the context to save any changes to the database 
                    context.SaveChanges();
                    Console.WriteLine("Added the book.");
                }
                else
                {
                    Console.WriteLine("Invalid book title and author, did not add book");
                }

                Console.WriteLine("The Current List of books are: ");
                // use a for each loop to loop through the students in the context
                // notice how similar this is to looping through a list
                foreach (Book s in context.Books)
                {
                    Console.WriteLine("{0} - {1} {2}",
                         s.Id, s.Title, s.Author);
                }

            }
        }
    }
    }

