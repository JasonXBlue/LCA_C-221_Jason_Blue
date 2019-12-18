using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TodoApp
{
    public class ToDoItem
    {
        //fields
        public int ID { get; private set; }
        public string Item { get; set; }
        public string DueDate { get; set; }
        public bool Pending { get; set; }
        

        //constructor
        public ToDoItem(string Item, string DueDate, bool Pending)
        {
            this.Item = Item;
            this.DueDate = DueDate;
            this.Pending = Pending;

        }
    }
}