using System;
namespace TodoApp
{
    public class ConsoleUtils
    {
        
        public ConsoleUtils()
        {
        }
        public ToDoItem EnterItem()
        {
            Console.WriteLine("Enter item:");
            string ItemEntry = Console.ReadLine();
            Console.WriteLine("Enter due date for item in DD/MM/YYYY format:");
            string DateEntry = Console.ReadLine();
            return new ToDoItem(ItemEntry, DateEntry, false, true);
        }
        public ToDoItem DeleteItem()
        {

        }
        public ToDoItem MarkItemDone()
        {

        }
        public ToDoItem ListDone()
        {

        }
        public ToDoItem ListPending()
        {

        }
        public ToDoItem ListAllItems()
        {

        }
    }
}
