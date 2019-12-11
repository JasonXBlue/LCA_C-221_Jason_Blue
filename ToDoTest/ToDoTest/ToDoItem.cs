using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace TodoApp
{
    class ToDoItem
    {
        //fields
        public int ID { get; private set; }
        public string Item { get; set; }
        public string DueDate { get; private set; }
        public bool Pending { get; set; }
        public bool Done { get; set; }

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
