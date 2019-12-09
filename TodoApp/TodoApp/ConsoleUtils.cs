using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace TodoApp
{
    public class ConsoleUtils
    {
        public ConsoleUtils()
        {

        }
        public static void UserInput()
        {
            bool Quit = false;
            while (!Quit)
            {
                ReviewList();
                Console.WriteLine("Do you want to 'add' an item, 'delete' an item ?");
                string Input = Console.ReadLine().ToLower();

                if (Input == "add")
                {
                    EnterItem();
                    Quit = true;
                }
            }
        }


        public static ToDoItem EnterItem()
        {
            Console.WriteLine("Enter item:");
            string ItemEntry = Console.ReadLine();
            Console.WriteLine("Enter due date for item in DD/MM/YYYY format:");
            string DateEntry = Console.ReadLine();
            return new ToDoItem(ItemEntry, DateEntry, false, true);
        }
        public static void DeleteItem()
        {

        }
        public static void ReviewList()
        {
            List<ToDoItem> ReviewToDoList = new List<ToDoItem>();
            Console.Clear();
            Console.WriteLine("ToDo List (ID | Description | Due Date | Status | ");
            Console.WriteLine();
            foreach (ToDoItem i in ReviewToDoList)
            {
                Console.WriteLine("   {0} | {1} | {2} | {3} | {4}", i.ID, i.Description, i.DueDate, i.Done);
            }
        }
        //public static void PrintList()
        //{
        //    ItemContext context = new ItemContext();
        //    foreach (ToDoItem item in context.)
        //    {
        //        Console.WriteLine("   {0} | {1} | {2} | {3} | {4}", item.ID, item.Description, item.DueDate, item.Done);
        //    }
        //}
     
    }
}
