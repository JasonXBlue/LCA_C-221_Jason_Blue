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
            int Count = 0;

            List<string> ItemList = new List<string>();
            List<string> DateList = new List<string>();
            List<string> PriorityList = new List<string>();
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
                        ItemList.Add(Item);
                        Console.WriteLine("Please enter the due date as MM/DD/YYYY including / in your entry:");
                        String Date = Console.ReadLine();
                        DateList.Add(Date);
                        Console.WriteLine("Please enter the priorty (High, Normal, or Low");
                        String Priority = Console.ReadLine().ToUpper();
                        PriorityList.Add(Priority);
                        Count++;

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
                Console.WriteLine(Count);
                foreach (string s in ItemList)
                {
                    Console.Write(s + " |");
                }
                foreach (string s in DateList)
                {
                    Console.Write(s + " |");
                }
                foreach (string s in PriorityList)
                {
                    Console.Write(s);
                }
                
            }
            
        }
    }
    class ToDoItem
    {
        public string Description { get; set; }
        public string DueDate { get; set; }
        public string Priority { get; set; }
    }


}

