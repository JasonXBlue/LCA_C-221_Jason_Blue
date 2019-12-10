﻿using System;
using Microsoft.EntityFrameworkCore;
using System.IO;
namespace TodoApp
{
    public class ItemContext : DbContext
    {
        public DbSet<ToDoItem> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the directory the code is being executed from
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);
            // get the base directory for the project
            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;
            // add 'items.db' to the project directory
            String DatabaseFile = Path.Combine(ProjectBase.FullName, "Items.db");
            // to check what the path of the file is, uncomment the file below
            //Console.WriteLine("using database file :"+DatabaseFile);
            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        }
        //public void Save(ToDoItem item)
        //{
        //    Database.ExecuteSqlCommand("INSERT INTO Items (Item, DueDate, Pending) VALUES ({0}, {1}, {2})", item.Item, item.DueDate, item.Pending);
        //}
    }
}
