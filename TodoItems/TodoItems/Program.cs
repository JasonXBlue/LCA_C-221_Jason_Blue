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
                Console.WriteLine("Please enter an item");
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

