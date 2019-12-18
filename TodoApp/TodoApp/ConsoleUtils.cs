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
                Console.WriteLine("** To Do List **");
                Console.WriteLine("\n[add] to add item: ");
                Console.WriteLine("[delete] to delete item: ");
                Console.WriteLine("[list] to list all items: ");
                Console.WriteLine("[done] to mark item done: ");
                Console.WriteLine("[listdone] to list all done items: ");
                Console.WriteLine("[pend] to list all pending items");
                Console.WriteLine("[quit] to quit: ");
                string Input = Console.ReadLine().ToLower();

                if (Input == "add")
                {
                    AddItem();
                    Console.Clear();
                }
                else if (Input == "delete")
                {
                    ItemRepository.GetAllToDoItems();
                    List<ToDoItem> allList = App.ListItems();
                    PrintList(allList);
                    Console.WriteLine("Enter the id number to delete: ");
                    int DelId = Convert.ToInt32(Console.ReadLine());
                    ItemRepository.DeleteItem(DelId);
                    Console.Clear();
                }
                else if (Input == "list")
                {
                    ItemRepository.GetAllToDoItems();
                    List<ToDoItem> allList = App.ListItems();
                    PrintList(allList);
                }
                else if (Input == "done")
                {
                    ItemRepository.GetAllToDoItems();
                    List<ToDoItem> allList = App.ListItems();
                    PrintList(allList);
                    Console.WriteLine("Enter the id of item you want to mark done :");
                    int IdDone = Convert.ToInt32(Console.ReadLine());
                    ItemRepository.MarkDone(IdDone);
                }

                else if (Input == "listdone")
                {
                    ItemRepository.GetToDoItems(Input);
                    List<ToDoItem> allList = App.ListItems("done");
                    PrintList(allList);
                }
                else if (Input == "quit")
                {
                    Quit = true;
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
            Console.WriteLine("Enter due date for item in DD/MM/YY format:");
            string dueDate = Console.ReadLine();
            App.AddItemApp(item, dueDate, true);
        }

        List<ToDoItem> List1 = App.ListItems();
        //method to print to do list
        public static void PrintList(List<ToDoItem> List1)
        {
            
            Console.WriteLine("** To Do List **");

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
