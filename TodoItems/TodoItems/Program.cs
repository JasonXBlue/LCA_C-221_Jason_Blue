using System;
using System.Collections.Generic;

namespace TodoItems
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Check = false;
            bool Quit = false;
      
            List<ToDoItem> MyList = new List<ToDoItem>();
            while (!Check)
            {
                Console.WriteLine("Enter A to add an item or Enter Q to quit:");
                String Response = Console.ReadLine().ToUpper();
                if (Response == "A")
                {
                    Check = true;
                    while (!Quit)
                    {
                        Console.WriteLine("Please enter an item description:");
                        String Item = Console.ReadLine();
                        Console.WriteLine("Please enter the due date as MM/DD/YYYY including / in your entry:");
                        String Date = Console.ReadLine();
                        Console.WriteLine("Please enter the priorty (High, Normal, or Low");
                        String Priority = Console.ReadLine().ToUpper();
                        MyList.Add(new ToDoItem(Item, Date, Priority));
                        Console.WriteLine("Enter A to add an item or Enter Q to quit:");
                        String Response1 = Console.ReadLine().ToUpper();
                        if (Response1 == "Q")
                        {
                            break;
                        }
                        else if (Response1 == "A")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Invalid entry.Enter A to add an item or Enter Q to quit:");
                            continue;
                        } 

                    }
                }
                Console.WriteLine("Description       |  Due Date  |  Priority");
                Console.WriteLine("------------------|------------|----------");
                foreach (ToDoItem Items in MyList)
                {

                    Items.PrintList();
                }
            }
            
        }
    }
    class ToDoItem
    {
        public string Item { get; set; }
        public string Date { get; set; }
        public string Priority { get; set; }

        public ToDoItem(string InitItem, string InitDate, string InitPriority)
        {
            Item = InitItem;
            Date = InitDate;
            Priority = InitPriority;
        }
        public void PrintList()
        {
            Console.WriteLine(" " + (Item) + "|" + (Date) + "|" + (Priority));
        }
    }


}

