using System;

namespace TodoItems
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Check = false;
            bool Quit = false;
            while (!Check)
            {
                Console.WriteLine("Enter A to add an item or Enter Q to quit:");
                String Response = Console.ReadLine().ToUpper();
                if (Response == "A")
                {
                    Check = true;
                }
                else if (Response == "Q")
                {
                    Check = true;
                    Quit = true;
                }
                else
                {
                    Check = false;
                    Console.WriteLine("Invalid entry.Enter A to add an item or Enter Q to quit:");  
                }
            }
            while (!Quit)
            {
                Console.WriteLine("Please enter an item description:");
                String Item = Console.ReadLine();
                Console.WriteLine("Please enter the due date as MM/DD/YYYY including / in your entry:");
                String Date = Console.ReadLine();
                Console.WriteLine("Please enter the priorty (High, Normal, or Low");
                String Priority = Console.ReadLine().ToUpper();
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

