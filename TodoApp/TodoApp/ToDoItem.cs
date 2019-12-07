using System;
namespace TodoApp
{
    public class ToDoItem
    {
        public string Description { get; set; }
        public string DueDate { get; private set; }
        public bool Done { get; set; }
        public bool Pending { get; set; }

        public ToDoItem(string Description, string Date, bool Done, bool Pending)
        {
            //this.Description = InitDescription;
            //this.DueDate = DueDate;
            //this.Done = InitDone;
            //this.Pending = InitStatus;
        }
    }
}
