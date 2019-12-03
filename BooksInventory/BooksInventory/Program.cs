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
                // ask the user for a book to add
                string[] Parts = new string[2];
                Console.WriteLine("Enter book title or Q to Quit:");
                String Title = Console.ReadLine();
                if (Title.ToUpper() == "Q")
                {
                    Quit = true;
                }
                else
                {
                    Parts[0] = Title;
                    Console.WriteLine("Enter the book author:");
                    String Author = Console.ReadLine();
                    Parts[1] = Author;
                    {
                        // create a new book object, notice that we do not 
                        // select an id, we let the framework handle that
                        Book newBook = new Book(Parts[0], Parts[1]);

                        // add the newly created book instance to the context
                        // notice how similar this is to adding a item to a list,
                        context.Books.Add(newBook);

                        // ask the context to save any changes to the database 
                        context.SaveChanges();
                        Console.WriteLine("Added the book.");
                    }
                }
                    Console.WriteLine("The Current List of books are: \n");
                    // use a for each loop to loop through the books in the context
                    // notice how similar this is to looping through a list
                    foreach (Book s in context.Books)
                    {
                        Console.WriteLine("{0} - Title: {1} | Author: {2}",
                             s.Id, s.Title, s.Author);
                    }

                }
            }
        }
    }


