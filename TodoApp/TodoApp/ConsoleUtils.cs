using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.Data.Sqlite;
using System.Linq;

namespace TodoApp
{
    public class ConsoleUtils
    {
        public App App;
        public ConsoleUtils()
        {
            App = new App();
        }
        //method to get input from user
        public static void UserInput()
        {
            bool Quit = false;
            while (!Quit)
            {
                //PrintList();
                Console.WriteLine("\nDo you want to 'add' an item, 'delete' an item, 'list' all items, 'done' to list done items, 'pend' to list pending items\n");
                Console.WriteLine("Enter 'add','delete', 'list', 'done', 'pend' :");
                string Input = Console.ReadLine().ToLower();

                if (Input == "add")
                {
                    AddItem();
                    Quit = true;
                }
                else if (Input == "delete")
                {
                    Console.WriteLine("Enter the id number to delete: ");
                    int DelId = Convert.ToInt32(Console.ReadLine());
                    ItemRepository.DeleteItem(DelId);
                }
                else if (Input == "list")
                {
                    ItemRepository.GetAllToDoItems();
                    List<ToDoItem> allList = App.ListItems();
                    PrintList(allList);
                }
                else if (Input == "done")
                {
                    ItemRepository.GetToDoItems(Input);
                    List<ToDoItem> allList = App.ListItems("done");
                    PrintList(allList);
                }
                else
                {
                    Console.WriteLine("You did not enter correct response. Please try again: ");
                }
            }
        }
        
        private static void PrintList(ItemContext todoList)
        {
            throw new NotImplementedException();
        }

        public static void AddItem()
        {
            Console.WriteLine("Enter description of To Do item:");
            string item = Console.ReadLine();
            Console.WriteLine("Enter due date for item in DD/MM/YYYY format:");
            string dueDate = Console.ReadLine();
            App.AddItemApp(item, dueDate, true);
        }

        List<ToDoItem> List1 = App.ListItems();
        //method to print to do list
        public static void PrintList(List<ToDoItem> List1)
        {
            
            Console.WriteLine("The Current List of items are: \n");

            if (List1 != null)
            {
                foreach (ToDoItem i in List1)
                {
                    Console.WriteLine("{0} - Item: {1} | DueDate: {2} | Pending {3}",
                         i.ID, i.Item, i.DueDate, i.Pending);
                }
            }
            else
            {
                Console.WriteLine("List is empty.");
            }
        }

    }
}
