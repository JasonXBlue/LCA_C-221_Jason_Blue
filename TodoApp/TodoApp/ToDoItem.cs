using System;
using System.Linq;
namespace TodoApp
{
    public class ToDoItem
    {
        //fields
        public string Item { get; set; }
        public string DueDate { get; private set; }
        public bool Done { get; set; }
        public bool Pending { get; set; }
        public int ID { get; private set; }
        //constructor
        public ToDoItem(string item, string date, bool done, bool pending)
        {
            Item = item;
            DueDate = date;
            Done = done;
            Pending = pending;
        }
    }
}
