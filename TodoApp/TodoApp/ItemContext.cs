using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Text;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;

namespace TodoApp
{
    public class ItemContext : DbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // get the directory the code is being executed from
        //    DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);
        //    // get the base directory for the project
        //    DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;
        //    // add 'items.db' to the project directory
        //    String DatabaseFile = Path.Combine(ProjectBase.FullName, "ToDoList.db");
        //    // to check what the path of the file is, uncomment the file below
        //    Console.WriteLine("using database file :" + DatabaseFile);
        //    optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=/Users/jasonblue/Desktop/ToDoList.db");
        }
    }
}
