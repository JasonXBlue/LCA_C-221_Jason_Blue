using System;
using System.Linq;
namespace TodoApp
{
    public class ToDoItem
    {
        //fields
        public string Description { get; set; }
        public string DueDate { get; private set; }
        public bool Done { get; set; }
        public bool Pending { get; set; }
        public int ID { get; private set; }
        //constructor
        public ToDoItem(string description, string date, bool done, bool pending)
        {
            Description = description;
            DueDate = date;
            Done = done;
            Pending = pending;
        }
    }
}
